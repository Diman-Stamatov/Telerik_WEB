using System.ComponentModel.DataAnnotations;

namespace WEB_Group_Project_Forum_System.Models.DTOs
{
    public class ReplyDto : PostDto
    {
        [Required(ErrorMessage = "Please specify the post you are replying to!")]        
        public int ThreadId { get; set; }
    }
}
