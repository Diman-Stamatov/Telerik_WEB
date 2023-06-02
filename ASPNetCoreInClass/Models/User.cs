using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreInClass.Models
{
    public class User
    {
        public int ID { get; set; }

        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long!")]
        [MaxLength(20, ErrorMessage = "The {0} must be at most {1} characters long!")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Please input a correct e-mail address!")]
        public string Email {get; set; }
    }
}
