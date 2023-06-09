using WEB_Group_Project_Forum_System.Models.QueryParameters;
using WEB_Group_Project_Forum_System.Models;
using WEB_Group_Project_Forum_System.Repositories;
using WEB_Group_Project_Forum_System.Services.Interfaces;

namespace WEB_Group_Project_Forum_System.Services
{
    public class UserServices : IUserServices
    {
        private readonly UsersRepository repository;

        public UserServices(UsersRepository repository)
        {
            this.repository = repository;
        }

        public User Create(User user)
        {
            return this.repository.Create(user);
        }

        public User Delete(int id)
        {
            return this.repository.Delete(id);
        }

        public List<User> FilterBy(UserQueryParameters filterParameters)
        {
            return this.repository.FilterBy(filterParameters);
        }

        public List<User> GetAll()
        {
            return this.repository.GetAll();
        }

        public User GetById(int id)
        {
            return this.repository.GetById(id);
        }

        public User Update(int id, User user)
        {
            return this.repository.Update(id, user);
        }
    }
}
