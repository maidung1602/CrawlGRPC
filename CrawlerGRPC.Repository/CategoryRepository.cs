using CrawlerGRPC.Context;
using CrawlerGRPC.Data;
using Dapper;


namespace CrawlerGRPC.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DapperContext _context;

        public CategoryRepository(DapperContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> Get()
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT Id, Url FROM Categories";
                return connection.Query<Category>(query);
            }
        }

        public int Add(Category category)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "INSERT INTO Categories (Url) VALUES (@Url); SELECT SCOPE_IDENTITY();";
                return connection.ExecuteScalar<int>(query, category);
            }
        }

        public int FindCategoryId(string categoryUrl)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT Id FROM Categories WHERE Url = @CategoryUrl";
                return connection.QueryFirstOrDefault<int>(query, new { CategoryUrl = categoryUrl });
            }
        }
    }
}
