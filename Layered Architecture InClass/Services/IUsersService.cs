using LayeredArchitectireInClass.Models;


namespace LayeredArchitectireInClass.Services
{
    public interface IUsersService
    {
        List<User> GetUsers();
        User GetByID(int id);        
        User Create(User user);
        User Update(int id, User user);
        void Delete(int id);
    }
}
