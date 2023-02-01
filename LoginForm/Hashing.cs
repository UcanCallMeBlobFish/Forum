using System.Security.Cryptography;
using System.Text;

namespace LoginForm;

public class Hashing
{
    public static string HashPassword(string pass)
    {
        var sha = SHA256.Create();
        var asByteArray = Encoding.Default.GetBytes(pass);
        var hashedPassword = sha.ComputeHash(asByteArray);

        return Convert.ToBase64String(hashedPassword);
    }
}