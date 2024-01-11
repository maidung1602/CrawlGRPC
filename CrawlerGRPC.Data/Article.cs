namespace CrawlerGRPC.Data
{
    public class Article
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int CategoryId { get; set; }
        public int Page { get; set; }
        public string? Url { get; set; }
        public DateTime CreatedAtUTC { get; set; }
    }
}
