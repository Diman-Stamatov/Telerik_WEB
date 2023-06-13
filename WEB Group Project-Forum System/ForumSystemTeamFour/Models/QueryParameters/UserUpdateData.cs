﻿using System.ComponentModel.DataAnnotations;

namespace ForumSystemTeamFour.Models.QueryParameters
{
    public class UserUpdateData
    {
        
        private const string StringMinLengthMessage = "The {0} must be at least {1} characters long!";
        private const string StringMaxLengthMessage = "The {0} must be at most {1} characters long!";

        [MinLength(4, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(32, ErrorMessage = StringMaxLengthMessage)]
        public string FirstName { get; set; }

        [MinLength(4, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(32, ErrorMessage = StringMaxLengthMessage)]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Please specify a valid e-mail address!")]
        public string Email { get; set; }

        [MinLength(4, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(20, ErrorMessage = StringMaxLengthMessage)]
        public string Username { get; set; }

        [MinLength(10, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(40, ErrorMessage = StringMaxLengthMessage)]
        public string Password { get; set; }

        [MinLength(9, ErrorMessage = StringMinLengthMessage)]
        [MaxLength(16, ErrorMessage = StringMaxLengthMessage)]
        public string PhoneNumber { get; set; }        
    }
}
