using WEB_Group_Project_Forum_System.Models.DTOs;
using WEB_Group_Project_Forum_System.Models;

namespace WEB_Group_Project_Forum_System.Mappers
{
    public class UserMapper
    {
        public User Map(UserDto userDto)
        {
            return new User
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Username = userDto.Username,
                Password = userDto.Password
            };
        }
    }
}
