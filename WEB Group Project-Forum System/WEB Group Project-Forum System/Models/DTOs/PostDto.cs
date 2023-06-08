using System.ComponentModel.DataAnnotations;

namespace WEB_Group_Project_Forum_System.Models.DTOs
{
    public abstract class PostDto
    {
        private protected const string StringEmptyMessage = "The {0} cannot be empty!";
        private protected const string StringMinLengthMessage = "The {0} must be at least {1} characters long!";
        private protected const string StringMaxLengthMessage = "The {0} must be at most {1} characters long!";        

        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [MinLength(10, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(8192, ErrorMessage = StringMaxLengthMessage)]
        public string Content { get; set; }
    }
}
