using LoginForm.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginForm.Data;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Post> Posts { get; set; }
    
    public DbSet<Likes> Lik { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
   
        
        modelBuilder.Entity<Likes>().HasData(
            new Likes { CompositeKey = "Post1Root", PostId = "Post1", LikedBy = "Root" }

        );
        modelBuilder.Entity<Person>().HasData(
            new Person { Name = "Root", RecoveryEmail = "Root@Root1", Email = "Root@Root1", Password = "Root" },
            new Person { Name = "Root2", RecoveryEmail = "Root@Root2", Email = "Root@Root2", Password = "Root" },
            new Person { Name = "Root3", RecoveryEmail = "Root@Root3", Email = "Root@Root3", Password = "Root" },
            new Person { Name = "Root4", RecoveryEmail = "Root@Root4", Email = "Root@Root4", Password = "Root" }
        );
        
       

        modelBuilder.Entity<Post>().HasData(
            new Post { PostId = "Post1", UserEmail = "user1@example.com", Text = "Example post 1", PostDate = DateTime.Now, Likes = 5 },
            new Post { PostId = "Post2", UserEmail = "user2@example.com", Text = "Example post 2", PostDate = DateTime.Now, Likes = 3 },
            new Post { PostId = "Post3", UserEmail = "user3@example.com", Text = "Example post 3", PostDate = DateTime.Now, Likes = 10 }
        );
        






    }
}