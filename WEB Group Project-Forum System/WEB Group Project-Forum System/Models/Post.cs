namespace WEB_Group_Project_Forum_System.Models
{
    public class Post
    {
        int PostId;
        int? ParentPostId;
        DateTime CreationDate;
        int AuthorId;
        string Title;
        string Content;
        List<int> Replies;
        List<int> Tags;

    }
}
