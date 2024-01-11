using CrawlerGRPC.Data;

namespace CrawlerGRPC.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Get();
        int Add(Category category);
        int FindCategoryId(string categoryUrl);
    }
}
