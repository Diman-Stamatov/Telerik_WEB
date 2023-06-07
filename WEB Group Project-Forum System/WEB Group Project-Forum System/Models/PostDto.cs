using System.ComponentModel.DataAnnotations;

namespace WEB_Group_Project_Forum_System.Models
{
    public class PostDto
    {
        private const string StringEmptyMessage = "The {0} cannot be empty!";
        private const string StringMinLengthMessage = "The {0} must be at least {1} characters long!";
        private const string StringMaxLengthMessage = "The {0} must be at most {1} characters long!";

        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [MinLength(10, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(50, ErrorMessage = StringMaxLengthMessage)]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [MinLength(10, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(8192, ErrorMessage = StringMaxLengthMessage)]
        public string Content { get; set; }
    }
}
