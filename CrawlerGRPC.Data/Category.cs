namespace CrawlerGRPC.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
