﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelloWorld
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


           // routes.MapRoute(
           //    name: "Teacher",
           //    url: "teacher",
           //    defaults: new { controller = "Teacher", action = "index" }
           //);

            routes.MapRoute(
               name: "Students",
               url: "student/{action}/{id}",
               defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Serial number",
               url: "Serial/{letterCase}",
               defaults: new { controller = "Home", action = "Serial", letterCase = "upper" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
