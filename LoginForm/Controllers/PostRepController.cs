using System.Security.Claims;
using LoginForm.IRepository;
using LoginForm.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginForm.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]")]
public class PostRepController : Controller
{
    private readonly IPostRep _post;
    // private readonly IPersonRep _context;

    public PostRepController(IPostRep post, IPersonRep context)
    {
        _post = post;
        // _context = context;
    }
    [HttpGet("search")]
    public IActionResult GetUserById(string username)
    {
        var users = _post.GetUserByID(username);
        if (users == null)
        {
            return BadRequest("User not found");
        }

        return Ok(users);
    }
    [HttpGet("GetAllUser")]
    public IActionResult GetUserById()
    {
        var users = _post.GetAll();
        if (users == null)
        {
            return BadRequest("User not found");
        }

        return Ok(users);
    }

    [HttpPost("Put Post")]
    public IActionResult AddPost(string text)
    {
        var username = User?.Identity?.Name;
        var email = User.FindFirstValue(ClaimTypes.Email);

        var PostedThing = _post.AddPost(text, email);
        return Ok(PostedThing);
    }

    [HttpPut("{PostId}")]
    public IActionResult Like(string PostId)
    {
        var username = User?.Identity?.Name;
        var email = User.FindFirstValue(ClaimTypes.Email);
        var likes = _post.Like(PostId, email);
        return Ok(likes);
    }
}