using System.ComponentModel.DataAnnotations;

namespace WEB_Group_Project_Forum_System.Models.DTOs
{
    public class UserDto
    {
        private const string StringEmptyMessage = "Please specify a {0}!";
        private const string StringMinLengthMessage = "The {0} must be at least {1} characters long!";
        private const string StringMaxLengthMessage = "The {0} must be at most {1} characters long!";

        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [MinLength(4, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(32, ErrorMessage = StringMaxLengthMessage)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [MinLength(4, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(32, ErrorMessage = StringMaxLengthMessage)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [EmailAddress(ErrorMessage = "Please specify a valid e-mail address!")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [MinLength(4, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(20, ErrorMessage = StringMaxLengthMessage)]
        public string Username { get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [MinLength(10, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(40, ErrorMessage = StringMaxLengthMessage)]
        public string Password { get; set; }
        
    }
}
