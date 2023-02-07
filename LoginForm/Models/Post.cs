using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginForm.Models;

public class Post
{
    [Key]
    public string PostId { get; set; }
    
    public string UserEmail { get; set; }
    
    [Required]
    public string Text { get; set; }

    public DateTime PostDate { get; set; } 
    
    public int Likes { get; set; }
    
    // public IEnumerable<Comment> Comments { get; set; }



}