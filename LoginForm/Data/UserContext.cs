using LoginForm.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginForm.Data;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().HasData(
            new Person { Name = "Root", RecoveryEmail = "Root@Root1", Email = "Root@Root1", Password = "Root" },
            new Person { Name = "Root2", RecoveryEmail = "Root@Root2", Email = "Root@Root2", Password = "Root" },
            new Person { Name = "Root3", RecoveryEmail = "Root@Root3", Email = "Root@Root3", Password = "Root" },
            new Person { Name = "Root4", RecoveryEmail = "Root@Root4", Email = "Root@Root4", Password = "Root" }
        );
    }
}