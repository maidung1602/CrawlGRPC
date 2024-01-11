using CrawlerGRPC.Data;

namespace CrawlerGRPC.Repository
{
    public interface IArticleRepository
    {
        Article Get(int id);
        IEnumerable<Article> Get(int categoryId, int page);
        void Delete(int id);
        int Add(Article article);
        bool Exists(string articleUrl);
        bool Exists(int id);
    }
}
