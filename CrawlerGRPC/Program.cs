using CrawlerGRPC.Context;
using CrawlerGRPC.Services;
using CrawlerGRPC.Repository;

namespace CrawlerGRPC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddGrpc();
            builder.Services.AddSingleton<DapperContext>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IArticleRepository, ArticleRepository>();

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            app.MapGrpcService<CrawlerService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}