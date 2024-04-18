using System.ComponentModel.Design.Serialization;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;
    public UsersController(DataContext context)
    {
        _context = context;
    }
    [HttpGet(Name = "Users")]
    public ActionResult<IEnumerable<AppUser>> GetUsers()
    {
        return _context.Users.ToList();
    }

    [HttpGet("{id}/{UserName}")]
    public ActionResult<AppUser> GetUser(int id, string UserName)
    {
        var user =_context.Users
                    .Where(user => user.Id == id && user.UserName == UserName)
                    .FirstOrDefault();
        return user;
    }
     [HttpGet("{id}")]
    public ActionResult<AppUser> GetUser(int id)
    {
        var user =_context.Users.Find(id);
        return user;
    }
}
