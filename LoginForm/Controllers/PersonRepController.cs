using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using LoginForm.IRepository;
using LoginForm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace LoginForm.Controllers;

[ApiController]

[Route("api/[controller]")]
public class PersonRepController : Controller
{
    private readonly IPersonRep _context;
    private readonly IConfiguration _configuration;


    public PersonRepController(IPersonRep obj, IConfiguration configuration)
    {
        _context = obj;
        _configuration = configuration;
    }

    [HttpPost("Login")]
    public IActionResult Login(string email, string password )
    {
        var person = _context.Login(email, password);
        if (person == null)
            return BadRequest("Invalid Email Or password");
        else
            return Ok(CreateToken(person));
    }


    [HttpPost("Register")]
    public IActionResult Register(Person guy)
    {
        var pers = _context.Register(guy);
        if (pers == null)
            return BadRequest("Email Already Used");
        else
            return Ok("Succesful Registration");
    }
    
    
    private string CreateToken(Person user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Name),
            new Claim(ClaimTypes.Email, user.Email)
        };

        var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
            _configuration.GetSection("AppSettings:Token").Value));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
}