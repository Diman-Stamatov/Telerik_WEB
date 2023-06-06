namespace WEB_Group_Project_Forum_System.Models
{
    public class User
    {
        public int UserID { get; set; }
        public bool IsAdmin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; }
        public string Password { get; set; }
        public bool Blocked { get; set; }
    }
}
