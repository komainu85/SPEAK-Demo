using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MikeRobbins.SPEAKDemo.IoC;

namespace MikeRobbins.SPEAKDemo.App_Start
{
    public static class IoCRegistration
    {
        static IContainer _containerProvider;

        public static void Initialise()
        {
            _containerProvider = IoCContainer.BuildContainer();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(_containerProvider));
        }

    }
}