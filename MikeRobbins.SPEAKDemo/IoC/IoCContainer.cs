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

namespace MikeRobbins.SPEAKDemo.IoC
{
    public static class IoCContainer
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());


            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            return builder.Build();
        }
    }
}