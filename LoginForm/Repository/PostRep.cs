using System.Drawing;
using LoginForm.Data;
using LoginForm.IRepository;
using LoginForm.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginForm.Repository;

public class PostRep : IPostRep
{
    private readonly UserContext _context;

    public PostRep(UserContext context)
    {
        _context = context;
    }
    

    public List<Person> GetUserByID(string UserId)
    {
        var users = _context.Persons.Where(a => a.Name == UserId).ToList();
        return users;

    }

    public List<Person> GetAll()
    {
        var users = _context.Persons.OrderBy(a => a.Name).ToList();
        return users;
    }

    public List<Post> GetUserPosts(string email)
    {
        var posts = _context.Posts.Where(a => a.UserEmail == email).ToList();
        return posts;
    }


    public Post AddPost(string text, string email)
    {
        Post post = new Post();
        post.Likes = 0;
        post.Text = text;
        post.PostDate = DateTime.Now;
        var tmp = _context.Posts.Count();
        post.PostId = tmp.ToString();
        post.UserEmail = email;
        _context.Add(post);
        _context.SaveChanges();
        return post;
    }

    public int Like(string PostId, string email)
    {
        string compositekey = PostId + email;
        var Isliked = _context.Lik.Where(a => a.CompositeKey == compositekey).FirstOrDefault();
        if (Isliked == null)
        {
            var PostToChangeLikes = _context.Posts.Where(a => a.PostId == PostId).FirstOrDefault();
            PostToChangeLikes.Likes++;
            _context.Posts.Update(PostToChangeLikes); //here update method find specific object by its primary key.
            _context.SaveChanges();
            Likes pers = new Likes();
            pers.PostId = PostId;
            pers.LikedBy = email;
            pers.CompositeKey = compositekey;
            _context.Lik.Add(pers);
            _context.SaveChanges();
            return PostToChangeLikes.Likes;
        }
        else
        {
            var lik = _context.Posts.Where(a => a.PostId == PostId).FirstOrDefault();
            return lik.Likes;
        }
    }
}