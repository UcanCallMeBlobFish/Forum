using LoginForm.Data;
using LoginForm.IRepository;
using LoginForm.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginForm.Repository;
public class PersonRep : IPersonRep
{
    private readonly UserContext _context; //db

    public PersonRep(UserContext context)
    {
        _context = context;
    }
    public Person Login(string email, string password)
    {
        var pas = Hashing.HashPassword(password);
        var pers = _context.Persons.Where(a => a.Email == email && a.Password == pas).FirstOrDefault();
        return pers;
    }
    public Person Register(Person obj)
    {
        var valid = _context.Persons.Where(a => a.Email == obj.Email).FirstOrDefault();
        if (valid == null)
        {
            _context.Persons.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        return null;
    }
}