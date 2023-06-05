namespace WEB_Group_Project_Forum_System.Models
{
    public class UserQueryParameters
    {               
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateTime MinDate { get; set; }
        public DateTime MaxDate { get; set; }
        public bool Blocked { get; set; }
        public string SortBy { get; set; }
        public string SortOrder { get; set; }
    }
}
