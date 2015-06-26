using MVCPageLifeCycle.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCPageLifeCycle
{
    public class RouteConfig
    {
        public class SampleRouteHandler : IRouteHandler
        {
            public System.Web.IHttpHandler GetHttpHandler(RequestContext requestContext)
            {
                return new SampleHttpHandler();
            }
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //var customRoute = new Route("Home/about", new SampleRouteHandler());
            //routes.Add(customRoute);
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
