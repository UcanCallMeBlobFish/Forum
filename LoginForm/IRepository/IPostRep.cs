using LoginForm.Models;

namespace LoginForm.IRepository;

public interface IPostRep
{
    Post AddPost(string email, string text);
     int Like(string PostId, string email);
     List<Person> GetUserByID(string UserId);
     List<Person> GetAll();
     List<Post> GetUserPosts(string email);
     



}