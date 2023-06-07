namespace WEB_Group_Project_Forum_System.Models.QueryParameters
{
    public class ReplyQueryParameters
    {
        public string Author { get; set; }

        public DateTime? MinDate { get; set; }
        public DateTime? MaxDate { get; set; }
        public string SortBy { get; set; }
        public string SortOrder { get; set; }
    }
}
