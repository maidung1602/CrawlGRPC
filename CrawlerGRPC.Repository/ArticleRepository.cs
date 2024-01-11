using CrawlerGRPC.Context;
using CrawlerGRPC.Data;
using Dapper;

namespace CrawlerGRPC.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly DapperContext _context;

        public ArticleRepository(DapperContext context)
        {
            _context = context;
        }

        public Article Get(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Articles WHERE Id = @Id";
                return connection.QueryFirstOrDefault<Article>(query, new { Id = id });
            }
        }

        public IEnumerable<Article> Get(int categoryId, int page)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM Articles WHERE (@CategoryId = 0 OR CategoryId = @CategoryId) AND Page = @Page ORDER BY CreatedAtUTC DESC";
                return connection.Query<Article>(query, new { CategoryId = categoryId, Page = page });
            }
        }

        public int Add(Article article)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = @"INSERT INTO Articles (Title, Content, CategoryId, Page, Url) 
                VALUES (@Title, @Content, @CategoryId, @Page, @Url);
                SELECT SCOPE_IDENTITY();";

                return connection.ExecuteScalar<int>(query, article);
            }
        }

        public void Delete(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "DELETE FROM Articles WHERE Id = @Id";
                connection.Execute(query, new { Id = id });
            }
        }

        public bool Exists(string articleUrl)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT COUNT(*) FROM Articles WHERE Url = @ArticleUrl";
                int count = connection.ExecuteScalar<int>(query, new { ArticleUrl = articleUrl });

                return count > 0;
            }
        }
        public bool Exists(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT COUNT(*) FROM Articles WHERE Id = @Id";
                int count = connection.ExecuteScalar<int>(query, new { Id = id });

                return count > 0;
            }
        }


    }
}
