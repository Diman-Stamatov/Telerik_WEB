namespace WEB_Group_Project_Forum_System.Models.QueryParameters
{
    public class ThreadQueryParameters : ReplyQueryParameters
    {
        public string Title { get; set; }
        public List<int> Tags { get; set; }
    }
}
