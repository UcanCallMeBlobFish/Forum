using System.ComponentModel.DataAnnotations;

namespace LoginForm.Models;

public class Person
{
    [Required] 
    public string Name { get; set; }

    public string RecoveryEmail { get; set; }

    [Key] 
    public string Email { get; set; }

    [Required] 
    [DataType(DataType.Password)]
    public string Password { get; set; }
}