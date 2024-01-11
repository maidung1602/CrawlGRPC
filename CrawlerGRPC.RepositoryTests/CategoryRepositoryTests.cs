using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrawlerGRPC.Repository;
using Microsoft.Extensions.Configuration;
using CrawlerGRPC.Context;
using NSubstitute;
using CrawlerGRPC.Data;
using System.Data;

namespace CrawlerGRPC.Repository.Tests
{
    [TestClass()]
    public class CategoryRepositoryTests
    {
        private IConfiguration configuration;
        private DapperContext dapperContext;
        private ICategoryRepository _categoryRepository;

        [TestInitialize]
        public void Initialize()
        {
            configuration = Substitute.For<IConfiguration>();
            configuration.GetConnectionString("SqlConnection").Returns("Server=localhost;Database=crawleddata;User Id=sa;Password=123;TrustServerCertificate=true");

            dapperContext = new DapperContext(configuration);
            _categoryRepository = new CategoryRepository(dapperContext);
        }

        [TestMethod()]
        public void GetTest()
        {
            var results = _categoryRepository.Get();

            Assert.IsNotNull(results);
            Assert.AreEqual(2, results.Count());
        }

        [TestMethod()]
        public void Add_Successfully()
        {
            var category = new Category
            {
               Url = "https://example.com/new-category"
            };

            int result = _categoryRepository.Add(category);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindCategoryId_Existing()
        {
            string categoryUrl = "https://example.com/new-category"; 

            int categoryId = _categoryRepository.FindCategoryId(categoryUrl);

            Assert.AreEqual(2, categoryId);
        }

        [TestMethod]
        public void FindCategoryId_NonExisting()
        {
            string categoryUrl = "https://example.com/non-existing-category";

            int categoryId = _categoryRepository.FindCategoryId(categoryUrl);

            Assert.AreEqual(0, categoryId);
        }
    }
}