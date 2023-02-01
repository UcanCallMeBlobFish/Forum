using LoginForm.Models;

namespace LoginForm.IRepository;

public interface IPersonRep
{
    Person Login(string email, string password);
    Person Register(Person obj);
}