using LayeredArchitectireInClass.Models;

namespace LayeredArchitectireInClass.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly List<User> users;
        public UsersRepository() 
        {
            this.users = new List<User>()
            {
                new User
                {
                    ID = 1,
                    Name = "John Smith",
                    Email = "John@Smith.Com"
                },
                new User
                {
                    ID = 2,
                    Name = "Jane Doe",
                    Email = "Jane@Doe.Com"
                },
                new User
                {
                    ID = 3,
                    Name = "Mark Twain",
                    Email = "Mark@Twain.Com"
                },
            };
        }
        public User Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public User GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User Update(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
