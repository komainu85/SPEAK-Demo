using Autofac;
using Autofac.Core;
using MikeRobbins.SPEAKDemo.IoC;
using MikeRobbins.SPEAKDemo.Models;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;

namespace MikeRobbins.SPEAKDemo.Controllers
{
    [ServicesController]
    public class NewsArticlesController : EntityService<NewsArticle>
    {
        private static IContainer _container;

        public static IContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = IoCContainer.BuildContainer();
                }

                return _container;
            }
        }


        public NewsArticlesController(IRepository<NewsArticle> repository) : base(repository)
        {
        }


        public NewsArticlesController() : this(Container.Resolve<Sitecore.Services.Core.IRepository<NewsArticle>>())
        {



        }

    }
}