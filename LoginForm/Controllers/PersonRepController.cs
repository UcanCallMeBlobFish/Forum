using LoginForm.IRepository;
using LoginForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginForm.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonRepController : Controller
{
    private readonly IPersonRep _context;

    public PersonRepController(IPersonRep obj)
    {
        _context = obj;
    }

    [HttpGet]
    public IActionResult Login(string email, string password)
    {
        var person = _context.Login(email, password);
        if (person == null)
            return BadRequest("Invalid Email Or password");
        else
            return Ok(person);
        
    }

    [HttpPost]
    public IActionResult Register(Person guy)
    {
        var pers = _context.Register(guy);
        if (pers == null)
            return BadRequest("Email Already Used");
        else
            return Ok("Succesful Registration");
    }
}