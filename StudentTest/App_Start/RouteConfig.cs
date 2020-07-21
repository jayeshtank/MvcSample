using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StudentTest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //   name: "route1",
            //   url: "students",
            //   defaults: new { controller = "Student", action = "GetStudentList", id = UrlParameter.Optional }
            //);
            
            //routes.MapRoute(
            //   name: "route2",
            //   url: "students/{action}/{id}",
            //   defaults: new { controller = "Student", action = "GetStudentList", id = UrlParameter.Optional }
            //);
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
