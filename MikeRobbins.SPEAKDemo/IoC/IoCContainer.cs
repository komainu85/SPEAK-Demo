using System.Reflection;
using Autofac;
using Autofac.Features.ResolveAnything;
using Autofac.Integration.Mvc;
using MikeRobbins.SPEAKDemo.DataAccess;
using MikeRobbins.SPEAKDemo.Interfaces;
using MikeRobbins.SPEAKDemo.Mapper;
using MikeRobbins.SPEAKDemo.Models;
using MikeRobbins.SPEAKDemo.Repositories;
using MikeRobbins.SPEAKDemo.Utilties;
using Sitecore.Services.Core;

namespace MikeRobbins.SPEAKDemo.IoC
{
    public static class IoCContainer
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());

            builder.RegisterType<NewsCreator>().As<INewsCreator>();
            builder.RegisterType<FieldUpdater>().As<IFieldUpdater>();
            builder.RegisterType<NewsUpdater>().As<INewsUpdater>();
            builder.RegisterType<NewsMapper>().As<INewsMapper>();
            builder.RegisterType<NewsReader>().As<INewsReader>();
            builder.RegisterType<SitecoreUtilities>().As<ISitecoreUtilities>();
            builder.RegisterType<NewsArticleRepository>().As<IRepository<NewsArticle>>();


            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            return builder.Build();
        }
    }
}