using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models.DTOs;
using WEB_Group_Project_Forum_System.Models.QueryParameters;

namespace WEB_Group_Project_Forum_System.Repositories.Interfaces
{
    public interface IRepliesRepository
    {
        List<Post> GetAll();
        List<Post> FilterBy(ReplyQueryParameters filterParameters);
        Post GetById(int id);
        Post Create(PostDto postDto);
        Post Update(int id, PostDto postDto);
        Post Delete(int id);
    }
}
