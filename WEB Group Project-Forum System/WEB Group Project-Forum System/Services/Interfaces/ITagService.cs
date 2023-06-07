using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models.QueryParameters;

namespace WEB_Group_Project_Forum_System.Services.Interfaces
{
    public interface ITagService
    {
        List<Post> GetAll();
        List<Post> FilterBy(ReplyQueryParameters filterParameters);
        Post GetById(int id);
        Post Create(string name);
        Post Update(int id, string name);
        Post Delete(string name);
    }
}
