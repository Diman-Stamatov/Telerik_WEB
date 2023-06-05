namespace WEB_Group_Project_Forum_System.Models
{
    public class PostQueryParameters
    {
        public string Title { get; set; }
        public List<int> Tags { get; set; }
        public DateTime MinDate { get; set; }
        public DateTime? MaxDate { get; set; }
        public string SortBy { get; set; }
        public string SortOrder { get; set; }
    }
}
