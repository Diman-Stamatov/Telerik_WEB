using ForumSystemTeamFour.Models;
using WEB_Group_Project_Forum_System.Models.DTOs;
using WEB_Group_Project_Forum_System.Models.QueryParameters;
using WEB_Group_Project_Forum_System.Repositories.Interfaces;

namespace WEB_Group_Project_Forum_System.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public Post Create(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Post Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> FilterBy(UserQueryParameters filterParameters)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Post Update(int id, UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
