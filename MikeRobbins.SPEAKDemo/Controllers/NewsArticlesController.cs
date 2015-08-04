using MikeRobbins.SPEAKDemo.Models;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;

namespace MikeRobbins.SPEAKDemo.Controllers
{
    [ServicesController]
    public class NewsArticlesController : EntityService<NewsArticle>
    {
        public NewsArticlesController(IRepository<NewsArticle> repository) : base(repository)
        {
        }
    }
}