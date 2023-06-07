using System.ComponentModel.DataAnnotations;

namespace WEB_Group_Project_Forum_System.Models.DTOs
{
    public class ThreadDto : PostDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = StringEmptyMessage)]
        [MinLength(10, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(50, ErrorMessage = StringMaxLengthMessage)]
        public string Title { get; set; }
    }
}
