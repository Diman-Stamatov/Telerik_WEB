using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models;
using WEB_Group_Project_Forum_System.Models.QueryParameters;

namespace WEB_Group_Project_Forum_System.Services.Interfaces
{
    public interface ITagService
    {
        List<Tag> GetAll();        
        Tag GetById(int id);
        Tag Create(string name);
        Tag Update(int id, string name);
        Tag Delete(string name);
    }
}
