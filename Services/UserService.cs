using BuildComp___Database.Models;
using BuildComp___Database.Models.DTO;
using BuildComp___Database.Services.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BuildComp___Database.Services
{
    public class UserService : ControllerBase
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }


        public bool DoesUserExist(string? Username)
        {
            // check the table to see if the username existsw
            // if 1 item matches the condition, return the item
            // if no item matches the condition, it will return null
            // if multiple items matches the condition, an error will occur

            return _context.UserInfo.SingleOrDefault(user => user.Username == Username) != null;

            // if something in the database already has that name it will return an object. But the function wants to return a bool, so the object is !null 
            // object != null; true
            // null != null; false


        }





        public bool AddUser(CreateAccountDTO UserToAdd)
        {
            // if the user already exists
            // if they do not exist we can then have the account be created 

            bool result = false;
            if (!DoesUserExist(UserToAdd.Username))
            {
                // if the user does not exist

                // Creating a new instance of user model (empty object)
                UserModel newUser = new UserModel();

                // create our salt and hash password
                var hashPassword = HashPassword(UserToAdd.Password);
                newUser.Id = UserToAdd.Id;
                newUser.Username = UserToAdd.Username;
                newUser.Salt = hashPassword.Salt;
                newUser.Hash = hashPassword.Hash;

                //Adding newUser to our database
                _context.Add(newUser);
                // this saves to our database and returns the number of entries that was written to the database
                //_context.SaveChanges();
                result = _context.SaveChanges() != 0;
            }

            return result;
            // else throw a false

        }


        public PasswordDTO HashPassword(string? password)
        {
            PasswordDTO newHashedPassword = new PasswordDTO();

            //New byte array at a length of 64
            byte[] SaltByte = new byte[64];
            var provider = new RNGCryptoServiceProvider();

            //enhanced rng of numbers without using zero
            provider.GetNonZeroBytes(SaltByte);

            // Encoding the 64 digits to string
            // salt makes the hash unique to the user
            // if we only had a hash password, every hash password would be the same
            // If people have the same password, the hash would be the same
            var Salt = Convert.ToBase64String(SaltByte);

            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, SaltByte, 10000);


            // encoding our password with our Salt
            // If anyone were to brute force this, it would take a decade to decode
            var Hash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            newHashedPassword.Salt = Salt;
            newHashedPassword.Hash = Hash;

            return newHashedPassword;


        }

        public bool VerifyUserPassword(string? Password, string? storeHash, string? storeSalt)
        {
            // get our existing salt and change it to base 64 string
            var SaltBytes = Convert.FromBase64String(storeSalt);

            // making a password that the user inputted and using the stored salt
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, SaltBytes, 10000);


            // created the new hash
            var newHash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));


            //Checking if the new hash is the same as the stored hash
            return newHash == storeHash;
        }


        public IActionResult Login(LoginDTO User)
        {
            //Want to return an error code if the user does not have a valid username or password
            IActionResult Result = Unauthorized();

            //Check to see if the user exists
            if (DoesUserExist(User.Username))
            {
                //True
                //We want to store the user object
                //To create another helper function
                UserModel foundUser = GetUserByUsername(User.Username);
                //Check if the password is correct
                if (VerifyUserPassword(User.Password, foundUser.Hash, foundUser.Salt))
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var tokeOptions = new JwtSecurityToken(
                        issuer: "http://localhost:5000",
                        audience: "http://localhost:5000",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(30),
                        signingCredentials: signinCredentials
                    );
                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                    Result = Ok(new { Token = tokenString });
                }
            }
            return Result;
        }

        public UserModel GetUserByUsername(string? username)
        {
            return _context.UserInfo.SingleOrDefault(user => user.Username == username);
        }

        public bool UpdateUser(UserModel userToUpdate)
        {
            // This is sending over the whole object to be updated

            _context.Update<UserModel>(userToUpdate);
            return _context.SaveChanges() != 0;
        }

         public bool UpdateUsername(int id, string username){
            // This one is sending over just the id and username 
            // We have to get the object to then be updated

            UserModel foundUser = GetUserById(id);
            bool result = false;
            if(foundUser != null){
                // This means a user was found
                // ***Remember*** Make sure that the username doesnt already exist

                foundUser.Username = username;
                _context.Update<UserModel>(foundUser);
                result = _context.SaveChanges() != 0;
                }
            return result;
        }

        public UserModel GetUserById(int id){
            return _context.UserInfo.SingleOrDefault(user => user.Id == id);
        }

         
         
         public bool DeleteUser(string userToDelete){
            // This one is just sending over the username 
            // We have to get the object to be deleted

            UserModel foundUser = GetUserByUsername(userToDelete);
            bool result = false;
            if(foundUser != null){
                // A user was found

                _context.Remove<UserModel>(foundUser);
                result = _context.SaveChanges() != 0;
            }

            return result;
        }




    }
}