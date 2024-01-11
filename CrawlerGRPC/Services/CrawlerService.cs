using Grpc.Core;
using HtmlAgilityPack;
using System.Web;
using CrawlerGRPC.Repository;
using CrawlerGRPC.Data;
using System;


namespace CrawlerGRPC.Services;

public class CrawlerService : Crawler.CrawlerBase
{
    enum CrawlerState
    {
        Stopped,
        Running
    }

    private readonly ILogger<CrawlerService> _logger;

    private readonly ICategoryRepository _categoryRepository;
    private readonly IArticleRepository _articleRepository;

    private readonly static  Queue<CrawlTask> _crawlTaskQueue = new Queue<CrawlTask>();
    private static int _runningTasks;
    private static CrawlTask? _currentTask;

    private static CrawlerState _state = CrawlerState.Stopped;
    private static DateTime _startTime;
    
    public CrawlerService(ILogger<CrawlerService> logger, ICategoryRepository categoryRepository, IArticleRepository articleRepository)
    {
        _logger = logger;

        _categoryRepository = categoryRepository;
        _articleRepository = articleRepository;
    }

    // Start

    public override Task<StartResponse> Start(StartRequest request, ServerCallContext context)
    {
        var message = "";

        if (_state == CrawlerState.Running)
        {
            message = "Crawler was started.";
        } else if (_crawlTaskQueue.Count == 0)
        {
            message = "No tasks in the queue to process.";
        } else
        {
            _startTime = DateTime.Now;
            _state = CrawlerState.Running;

            message = "Start crawling";

            Task.Run(() =>
            {
                ProcessQueue();
            });
        }

        return Task.FromResult(new StartResponse
        {
            Message = message
        }) ;
    }

    private void ProcessQueue()
    {
        while (_state == CrawlerState.Running)
        {
            if(_crawlTaskQueue.Count > 0)
            {
                var task = _crawlTaskQueue.Dequeue();
                _currentTask = task;
                Interlocked.Increment(ref _runningTasks);

                Crawling(task);
                _currentTask = null;
                Interlocked.Decrement(ref _runningTasks);
            } else
            {
                _state = CrawlerState.Stopped;
            }
        }
    }

    public void Crawling(CrawlTask crawlTask)
    {
        var categoryUrl = crawlTask.CategoryUrl;
        var categoryId = _categoryRepository.FindCategoryId(categoryUrl);

        if (categoryId == 0)
        {
            var newCategory = new Category();
            newCategory.Url = categoryUrl;

            categoryId = _categoryRepository.Add(newCategory);
        }

        var tasks = new List<Task>();

        for (var page = 1; page <= crawlTask.Pages; page++)
        {
            int currentPage = page;

            string url = $"{categoryUrl}/trang-{currentPage}.htm";

            tasks.Add(Task.Run(() =>
            {
                ProcessPage(url, currentPage, categoryId);
            }));
        }

        Task.WaitAll(tasks.ToArray());
    }


    public void ProcessPage(string url, int currentPage, int categoryId)
    {
        HtmlWeb web = new HtmlWeb();
        try
        {
            HtmlDocument doc = web.Load(url);
            var articles = doc.DocumentNode.SelectNodes("//article[@class='article-item']");
            var articleLinks = new List<HtmlNode>();

            if (articles != null)
            {
                foreach (var article in articles)
                {
                    var link = article.SelectSingleNode(".//a[contains(@href, '/suc-manh-so/')]");
                    if (link != null)
                    {
                        articleLinks.Add(link);
                    }
                }
            }

            if (articleLinks != null)
            {
                foreach (var link in articleLinks)
                {
                    string articleUrl = "https://dantri.com.vn" + link.GetAttributeValue("href", "");

                    if (!_articleRepository.Exists(articleUrl))
                    {
                        HtmlDocument articleDoc = web.Load(articleUrl);

                        string title = HttpUtility.HtmlDecode(articleDoc.DocumentNode.SelectSingleNode("//h1")?.InnerText ?? "");
                        string content = articleDoc.DocumentNode.SelectSingleNode("//article[@class='singular-container']")?.InnerHtml;

                        if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(content))
                        {
                            Article newArticle = new Article
                            {
                                Title = title,
                                Content = content,
                                CategoryId = categoryId,
                                Page = currentPage,
                                Url = articleUrl,
                            };
                            _articleRepository.Add(newArticle);
                        }
                    }
                }
            }
        } catch (Exception ex)
        {
            Console.WriteLine(url);
            Console.WriteLine(ex.Message);
        }
    }

    // Stop

    public override Task<StopResponse> Stop(StopRequest request, ServerCallContext context)
    {
        var message = "";
        if (_state == CrawlerState.Stopped)
        {
            message = "Crawler has not been started";
        } else
        {
            _state = CrawlerState.Stopped;
            message = "Stop succesfully.";
        }
       
        return Task.FromResult(new StopResponse()
        {
            Message = message
        });
    }

    // Crawl

    public override Task<CrawlResponse> Crawl(CrawlRequest request, ServerCallContext context)
    {
        var message = "";
        if (ValidateUrl(request.CategoryUrl) && ValidatePosInt(request.Pages))
        {
            _crawlTaskQueue.Enqueue(new CrawlTask
            {
                CategoryUrl = request.CategoryUrl,
                Pages = request.Pages
            });

            message = $"Add a crawl request for the category URL '{request.CategoryUrl}' with {request.Pages} pages successfully";
        } else if (!ValidateUrl(request.CategoryUrl))
        {
            message = "Invalid category URL provided.";
        } else if (!ValidatePosInt(request.Pages))
        {
            message = "Invalid number of pages provided. Pages should be a positive integer.";
        }

        return Task.FromResult(new CrawlResponse()
        {
            Message = message
        });
    }

    public bool ValidateUrl(string url)
    {
        try
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
        } catch (Exception)
        {
            return false;
        }
        return true;
    }

    public bool ValidatePosInt(int value)
    {
        return value > 0;
    }

    // Delete

    public override Task<DeleteResponse> Delete(DeleteRequest request, ServerCallContext context)
    {
        var message = "";
        if (!_articleRepository.Exists(request.Id))
        {
            message = $"Not exist article with id = {request.Id}";

        } else
        {
            _articleRepository.Delete(request.Id);
            message = $"Article with ID = {request.Id} is deleted successfully";
        }

        return Task.FromResult(new DeleteResponse()
        {
            Message = message
        }) ;
    }

    // Status

    public override Task<StatusResponse> Status(StatusRequest request, ServerCallContext context)
    {
        TimeSpan runningTime = _state == CrawlerState.Running ? DateTime.Now - _startTime : TimeSpan.Zero;
        string formattedRunningTime = runningTime.ToString(@"hh\:mm\:ss\:fff");

        var response = new StatusResponse
        {
            TaskCount = _runningTasks,
            RunningTime =  formattedRunningTime,
            RunningTask = _currentTask,
        };

        return Task.FromResult(response);
    }

    // GetCategories

    public override Task<CategoriesResponse> GetCategories(CategoriesRequest request, ServerCallContext context)
    {
        var categories = _categoryRepository.Get();

        var response = new CategoriesResponse();
        response.Categories.AddRange(categories.Select(c => new CategoryM
        {
            Id = c.Id,
            Url = c.Url
        }));

        return Task.FromResult(response);
    }

    // GetArticle (By ID)

    public override Task<ArticleResponse> GetArticle(ArticleRequest request, ServerCallContext context)
    {
        var article = _articleRepository.Get(request.Id);
        var response = new ArticleResponse
        {
            Articles = article != null ? new ArticleM
            {
                Id = article.Id,
                Title = article.Title,
                CategoryId = article.CategoryId,
                Page = article.Page,
            } : null
        };

        return Task.FromResult(response);
    }

    // GetArticles (By CategoryId and Page)

    public override Task<ArticlesResponse> GetArticles(ArticlesRequest request, ServerCallContext context)
    {
        var articles = _articleRepository.Get(request.CategoryId, request.Page);

        var response = new ArticlesResponse
        {
            Articles = { articles.Select(a => new ArticleM
            {
                Id = a.Id,
                Title = a.Title,
                CategoryId = a.CategoryId,
                Page = a.Page,
            }) }
        };

        return Task.FromResult(response);
    }


}