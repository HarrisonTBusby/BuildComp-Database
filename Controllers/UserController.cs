using BuildComp_Database.Models;
using BuildComp_Database.Models.DTO;
using BuildComp_Database.Services;
using Microsoft.AspNetCore.Mvc;


namespace BuildComp_Database.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _data;
    public UserController(UserService dataFromService)
    {
        _data = dataFromService;

    }

    //Login Endpoint
    [HttpPost("Login")]
    public IActionResult Login([FromBody] LoginDTO User)
    {
        return _data.Login(User);
    }

    //Add a user endpoint
    // if the user already exists
    // if they do not exist we can then have the account be created 
    // else throw a false

    [HttpPost("AddUser")]
    public bool AddUser(CreateAccountDTO UserToAdd)
    {
        return _data.AddUser(UserToAdd);

    }


    //Update User account Endpoint

    [HttpPost("UpdateUser")]

    public bool UpdateUser(UserModel userToUpdate)
    {
        return _data.UpdateUser(userToUpdate);
    }



    [HttpPost("UpdateUser/{id}/{username}")]

    public bool UpdateUser(int id, string username)
    {
        return _data.UpdateUsername(id, username);
    }



    //Delete user account endpoint
    [HttpDelete("DeleteUser/{userToDelete}")]

    public bool DeleteUser(string userToDelete)
    {
        return _data.DeleteUser(userToDelete);
    }

   

}