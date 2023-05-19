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

    [HttpPost("Login")]
    public IActionResult Login([FromBody] LoginDTO User)
    {
        return _data.Login(User);
    }

    [HttpPost("AddUser")]
    public bool AddUser(CreateAccountDTO UserToAdd)
    {
        return _data.AddUser(UserToAdd);

    }

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

    [HttpDelete("DeleteUser/{userToDelete}")]
    public bool DeleteUser(string userToDelete)
    {
        return _data.DeleteUser(userToDelete);
    }
}