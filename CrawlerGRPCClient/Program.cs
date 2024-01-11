using Grpc.Net.Client;

namespace CrawlerGRPCClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7298");
            var client = new Crawler.CrawlerClient(channel);

            string? readResult;
            string menuSelection = "";

            do
            {
                Console.WriteLine("Welcome to the Crawler. Your main menu options are:");
                Console.WriteLine(" 1. Start");
                Console.WriteLine(" 2. Stop");
                Console.WriteLine(" 3. Crawl");
                Console.WriteLine(" 4. Status");
                Console.WriteLine(" 5. Delete an article");
                Console.WriteLine(" 6. Get catgories");
                Console.WriteLine(" 7. Get article by ID");
                Console.WriteLine(" 8. Get articles by categoryId and page");
                Console.WriteLine(" 9. Exit");
                Console.WriteLine(" Enter your selection number:");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                switch (menuSelection)
                {
                    case "1":
                        var startResponse =  client.Start(new StartRequest());

                        Console.ForegroundColor = startResponse.Message == "Start crawling" ? ConsoleColor.Green : ConsoleColor.Red;
                        Console.WriteLine(startResponse.Message);
                        Console.ResetColor();

                        Console.WriteLine();
                        break;

                    case "2":
                        var stopResponse =  client.Stop(new StopRequest());

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(stopResponse.Message);
                        Console.ResetColor();

                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine("Enter the category URL:");
                        string? categoryUrl = Console.ReadLine();

                        Console.WriteLine("Enter the page number (integer):");
                        int pages;
                        while (!int.TryParse(Console.ReadLine(), out pages))
                        {
                            Console.WriteLine("Please enter an integer:");
                        }

                        var crawlResponse = client.Crawl(new CrawlRequest()
                        {
                            CategoryUrl = categoryUrl,
                            Pages = pages
                        });
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(crawlResponse.Message);
                        Console.ResetColor();
                        Console.WriteLine();    
                        break;

                    case "4":
                        var statusResponse =  client.Status(new StatusRequest());

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Status: ");
                        Console.ResetColor();

                        Console.WriteLine($"Task Count: {statusResponse.TaskCount}");
                        Console.WriteLine($"Running Task: {statusResponse.RunningTask}");
                        Console.WriteLine($"Running Time: {statusResponse.RunningTime}");

                        Console.WriteLine();
                        break;

                    case "5":
                        Console.WriteLine("Enter the article id:");
                        int id;
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Please enter an integer:");
                        }

                        var deleteResponse = client.Delete(new DeleteRequest()
                        {
                            Id = id
                        });

                        Console.ForegroundColor = deleteResponse.Message.StartsWith("Not") ? ConsoleColor.Red : ConsoleColor.Green;
                        Console.WriteLine(deleteResponse.Message);
                        Console.ResetColor();

                        Console.WriteLine();
                        break;

                    case "6":
                        var categoriesResponse =client.GetCategories(new CategoriesRequest());

                        if (categoriesResponse.Categories.Count != 0)
                        {
                            Console.WriteLine("All categories: ");
                            foreach (var category in categoriesResponse.Categories)
                            {
                                Console.WriteLine(category);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No categories found.");
                        }

                        Console.WriteLine();
                        break;

                    case "7":
                        Console.WriteLine("Enter the article id:");
                        int articleId;
                        while (!int.TryParse(Console.ReadLine(), out articleId))
                        {
                            Console.WriteLine("Please enter an integer:");
                        }

                        var articleResponse = client.GetArticle(new ArticleRequest()
                        {
                            Id = articleId
                        });

                        if (articleResponse.Articles != null)
                            Console.WriteLine(articleResponse.Articles);
                        else
                            Console.WriteLine($"Not exist article with id = {articleId}");

                        Console.WriteLine();
                        break;

                    case "8":
                        Console.WriteLine("Enter the category id:");
                        int categoryId;
                        while (!int.TryParse(Console.ReadLine(), out categoryId))
                        {
                            Console.WriteLine("Please enter an integer:");
                        }

                        Console.WriteLine("Enter the page:");
                        int page;
                        while (!int.TryParse(Console.ReadLine(), out page))
                        {
                            Console.WriteLine("Please enter an integer:");
                        }

                        var articlesResponse = client.GetArticles(new ArticlesRequest()
                        {
                            CategoryId = categoryId,
                            Page = page
                        });

                        if (articlesResponse.Articles.Count != 0)
                        {
                            foreach (var ar in articlesResponse.Articles)
                            {
                                Console.WriteLine(ar);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No articles found with categoryId = {categoryId} and page = {page}");
                        }

                        Console.WriteLine();
                        break;

                    default:
                        break;
                }

            } while (menuSelection != "9");
        }
    }
}
