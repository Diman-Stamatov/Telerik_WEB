using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models;
using WEB_Group_Project_Forum_System.Models.DTOs;
using WEB_Group_Project_Forum_System.Models.QueryParameters;

namespace WEB_Group_Project_Forum_System.Repositories.Interfaces
{
    public interface ITagsRepository
    {
        List<Tag> GetAll();        
        Tag GetById(int id);
        Tag GetByName(string name);
        Tag Create(string name);        
        Tag Delete(string name);
    }
}
