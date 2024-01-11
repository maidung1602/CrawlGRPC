using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrawlerGRPC.Context;
using Microsoft.Extensions.Configuration;
using NSubstitute;
using CrawlerGRPC.Data;

namespace CrawlerGRPC.Repository.Tests
{
    [TestClass]
    public class ArticleRepositoryTests
    {
        private IConfiguration configuration;
        private DapperContext dapperContext;
        private IArticleRepository _articleRepository;

        [TestInitialize]
        public void Initialize()
        {
            configuration = Substitute.For<IConfiguration>();
            configuration.GetConnectionString("SqlConnection").Returns("Server=localhost;Database=crawleddata;User Id=sa;Password=123;TrustServerCertificate=true");

            dapperContext = new DapperContext(configuration);
            _articleRepository = new ArticleRepository(dapperContext);
        }

        [TestMethod]
        public void Get_ValidId()
        {
            int validId = 1;

            var result = _articleRepository.Get(validId);

            Assert.IsNotNull(result);
            Assert.AreEqual(validId, result.Id);
        }

        [TestMethod]
        public void Get_InvalidId()
        {
            int invalidId = -1;

            var result = _articleRepository.Get(invalidId);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Get_WithCategoryIdAndPage()
        {
            int categoryId = 1;
            int page = 1;

            var results = _articleRepository.Get(categoryId, page);

            Assert.IsNotNull(results);
            Assert.AreEqual(19, results.Count());
        }

        [TestMethod]
        public void Get_WithAllCategoryAndPage()
        {
            int categoryId = 0;
            int page = 1;

            var results = _articleRepository.Get(categoryId, page);

            Assert.IsNotNull(results);
            Assert.AreEqual(19, results.Count());
        }

        [TestMethod]
        public void Get_WithInvalidCategoryId()
        {
            int categoryId = -1;
            int page = 1;

            var results = _articleRepository.Get(categoryId, page);

            Assert.AreEqual(0, results.Count());
        }

        [TestMethod]
        public void Add_Successful()
        {
            var article = new Article
            {
                Title = "New Article",
                Content = "New article content",
                CategoryId = 1,
                Page = 2,
                Url = "https://example.com/new-article"
            };

            int result = _articleRepository.Add(article);

            Assert.AreEqual(111, result);
        }

        [TestMethod]
        public void Delete_Succesfully()
        {
            int idToDelete = 2;

            _articleRepository.Delete(idToDelete);

            var deletedArticle = _articleRepository.Get(idToDelete);

            Assert.IsNull(deletedArticle);
        }

        [TestMethod]
        public void Exists_ExistingId()
        {
            int existingId = 1;

            bool result = _articleRepository.Exists(existingId);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Exists_NonExistingId()
        {
            int nonExistingId = -1; 

            bool result = _articleRepository.Exists(nonExistingId);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Exists_ExistingUrl()
        {
            string existingUrl = "https://example.com/new-article"; 

            bool result = _articleRepository.Exists(existingUrl);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Exists_NonExistingUrl()
        {
            string nonExistingUrl = "https://example.com/non-existing-url"; 

            bool result = _articleRepository.Exists(nonExistingUrl);

            Assert.IsFalse(result);
        }
    }
}
