using System.ComponentModel.DataAnnotations;

namespace WEB_Group_Project_Forum_System.Models
{
    public class PostDto
    {
        private const string StringEmptyMessage = "Please specify a {0}!";
        private const string StringMinLengthMessage = "The {0} must be at least {1} characters long!";
        private const string StringMaxLengthMessage = "The {0} must be at most {1} characters long!";

        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [MinLength(10, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(50, ErrorMessage = StringMaxLengthMessage)]
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        int AuthorId { get; set; }
        public string Content { get; set; }
        public List<int> Replies { get; set; }
        public List<int> Tags { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
