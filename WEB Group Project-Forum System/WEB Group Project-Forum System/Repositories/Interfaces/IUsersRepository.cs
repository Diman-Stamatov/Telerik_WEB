using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models;
using WEB_Group_Project_Forum_System.Models.DTOs;
using WEB_Group_Project_Forum_System.Models.QueryParameters;

namespace WEB_Group_Project_Forum_System.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        List<User> GetAll();
        List<User> FilterBy(UserQueryParameters filterParameters);
        User GetById(int id);
        User GetByUsername(string username);
        User Create(User user);
        User Update(int id, User user);
        User Delete(int id);
    }
}
