using WEB_Group_Project_Forum_System.Models.QueryParameters;
using WEB_Group_Project_Forum_System.Models;

namespace WEB_Group_Project_Forum_System.Services.Interfaces
{
    public interface IUserServices
    {
        List<User> GetAll();
        List<User> FilterBy(UserQueryParameters filterParameters);
        User GetById(int id);
        User Create(User user);
        User Update(int id, User user);
        User Delete(int id);
    }
}
