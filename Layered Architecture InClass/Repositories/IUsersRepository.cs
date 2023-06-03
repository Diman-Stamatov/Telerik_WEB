using LayeredArchitectireInClass.Models;

namespace LayeredArchitectireInClass.Repositories
{
    public interface IUsersRepository
    {        
        List<User> GetAll();
        User GetByID(int id);
        User GetByName(string name);
        User Create(User user);
        User Update(int id, User user);
        void Delete(int id); 
    }
}
