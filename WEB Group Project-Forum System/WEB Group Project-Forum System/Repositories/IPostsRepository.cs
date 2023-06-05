using WEB_Group_Project_Forum_System.Models;

namespace WEB_Group_Project_Forum_System.Repositories
{
    public interface IPostsRepository
    {
        List<Post> GetAll();
        List<Post> FilterBy(PostQueryParameters filterParameters);
        Post GetById(int id);
        Post Create(PostDto postDto);
        Post Update(int id, PostDto postDto);
        Post Delete(int id);
    }
}
