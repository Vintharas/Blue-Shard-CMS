﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BlueShardCMS.Infrastructure;
using BlueShardCMS.Storage.Infrastructure;
using BlueShardCMS.Storage.Interfaces;
using Ninject;

namespace BlueShardCMS
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        private StandardKernel ninjectKernel;

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                null,
                "{controller}/{action}/{permalink}",
                new {controller = "Page", action = "Index", permalink = UrlParameter.Optional});

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            RegisterDependencyResolver();
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        private void RegisterDependencyResolver()
        {
            ninjectKernel = new StandardKernel();
            SetupNinject();
            DependencyResolver.SetResolver(new NinjectDependencyResolver(ninjectKernel));
        }

        private void SetupNinject()
        {
            ninjectKernel.Bind<IPageRepository>().To<PageRepository>();
        }
    }
}