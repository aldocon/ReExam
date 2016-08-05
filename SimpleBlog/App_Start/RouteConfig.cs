using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            var namespaces = new[] {typeof(PostsController).Namespace};

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("TagFix", "tag/{idAndSlug}", new {controller = "Posts", action = "Tag"},namespaces);
            routes.MapRoute("Tag", "tag/{id}-{slug}", new { controller = "Posts", action = "Tag" }, namespaces);

            routes.MapRoute("RouteFix", "post/{idAndSlug}", new{controller = "Posts", action = "show"}, namespaces);
            routes.MapRoute("Post", "post/{id}-{slug}", new {controller = "Posts", action = "show"}, namespaces);

            routes.MapRoute("Login", "login", new {controller = "Auth", action = "Login"},namespaces);
            routes.MapRoute("Logout", "logout", new { controller = "Auth", action = "Logout" }, namespaces);


            routes.MapRoute("Home", "", new {controller = "Posts", action = "Index"},namespaces);

            routes.MapRoute("Sidebar", "", new {controller = "Layout", action = "Sidebar"}, namespaces);

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
