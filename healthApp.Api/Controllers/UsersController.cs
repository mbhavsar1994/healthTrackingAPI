using lifehealth.Entities.DbSet;
using lifehealth.Entities.Dtos.Incoming;
using lifeHealth.DataService.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace healthApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{

    private AppDbContext _context;

    public UsersController(AppDbContext context)
    {
        _context = context;
    }

    //Get All
    [HttpGet]
    public async Task<IActionResult> GetUsers() 
    {
        var users = await _context.Users.Where(i => i.Status == 1).ToListAsync();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> AddUser(UserDto user)
    {
        var _user = new User();

        _user.FirstName = user.FirstName;
        _user.LastName = user.LastName;
        _user.Phone = user.Phone;
        _user.Email = user.Email;
        _user.Status = 1;
        _user.DateOfBirth = Convert.ToDateTime(user.DateOfBirth);
        _user.Country = user.Country;

        await  _context.Users.AddAsync(_user);
        await _context.SaveChangesAsync();

        return Ok();
    }

    //Get by Id

    [HttpGet]
    [Route("GetUser")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
       return Ok(_context.Users.Where(i => i.Status == 1 && i.Id == id));
    }
}
