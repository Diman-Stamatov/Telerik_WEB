namespace WEB_Group_Project_Forum_System.Models
{
    public class User
    {
        int UserID;
        string FirstName;
        string LastName;
        string Email;
        readonly string Username;
        string Password;
        bool Blocked;
    }
}
