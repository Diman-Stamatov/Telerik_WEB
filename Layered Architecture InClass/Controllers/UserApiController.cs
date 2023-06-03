using LayeredArchitectireInClass.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace LayeredArchitectireInClass.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserApiController : Controller
    {
        public static List<User> users = new List<User>();
        static int Id = 1;

        [HttpGet("")]
        public IActionResult GetUsers()
        {
            if (users.Count == 0)
            {
                return NotFound("No users have been registered yet!");
            }
            else
            {
                return Ok(users);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUsersByID(int id)
        {
            var foundUser = users.FirstOrDefault(user => user.ID == id);
            if (foundUser == null)
            {
                return NotFound($"User ID number {id} is not in the Database!");
            }
            return Ok(foundUser);
        }

        [HttpPost("")]
        public IActionResult PostUser([FromBody] User user) 
        {
            user.ID = Id++;
            users.Add(user);
            return StatusCode(StatusCodes.Status201Created, user);
        }

        [HttpPut("{id},{name},{email}")]
        public IActionResult PutUser(int id, string name, string email) 
        {
            var foundUser = users.FirstOrDefault(user => user.ID == id);
            if (foundUser == null) 
            {
                return NotFound($"User ID number {id} is not in the Database!");
            }
            else
            {
                foundUser.Name = name;
                foundUser.Email = email;
            }
            return StatusCode(StatusCodes.Status202Accepted, foundUser);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            int foundUserIndex = users.FindIndex(user => user.ID == id);
            if (foundUserIndex == -1)
            {
                return NotFound($"User ID number {id} is not in the Database!");
            }
            else
            {
                users.RemoveAt(foundUserIndex);
            }
            return Ok();
        }

    }
}
