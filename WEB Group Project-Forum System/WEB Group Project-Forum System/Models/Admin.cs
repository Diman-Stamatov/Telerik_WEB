using ForumSystemTeamFour.Models.Interfaces;

namespace WEB_Group_Project_Forum_System.Models
{
    public class Admin : User, IAdmin
    {
        public int? PhoneNumber { get; set; }
    }
}
