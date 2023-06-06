namespace WEB_Group_Project_Forum_System.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int? ParentPostId { get; set; }
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
