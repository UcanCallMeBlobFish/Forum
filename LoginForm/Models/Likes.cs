using System.ComponentModel.DataAnnotations;

namespace LoginForm.Models;

public class Likes
{
    
    [Key]
    public string CompositeKey { get; set; }
    public string PostId { get; set; }
    
    public string LikedBy { get; set; } // email
}