using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MVCPageLifeCycle;
using MVCPageLifeCycle.Controllers;
using System.Diagnostics;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), "Register")]

namespace MVCPageLifeCycle
{
    public class MvcApplication : System.Web.HttpApplication
    {
       
        public static void Register()
        {
            //HttpApplication.RegisterModule(typeof(LogModule));
        }

        protected void Application_Start()
        {
            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_Error()
        {
            // fires when there is any unhandled exception thrown in the application
        }

        protected void Application_End()
        {
            // fires when application ends.
        }
        protected void Application_BeginRequest()
        {
            // fires when the request processing begings inside your application
        }
        protected void Application_AuthenticateRequest()
        {
            // fires just before the request is authenticated. You can specify your own authentication logic over here.
        }
        protected void Application_AuthorizeRequest()
        {
            // fires on successful authentication of user’s credentials.
            // You can use this method to give authorization rights to user.
        }
        protected void Application_ResolveRequestCache()
        {
            // fires on successful completion of an authorization request.
            // resolves the request cache
        }
        protected void Application_AcquireRequestState()
        {
            // fires just before the session state is retrieved for the current request.
        }
        protected void Application_PreRequestHandlerExecute()
        {
            // fires before the page framework begins before executing an event handler to handle the request.
            Debug.WriteLine("PreExecute");
        }
        protected void Application_PostRequestHandlerExecute()
        {
            // fires after HTTP handler has executed the request.
            Debug.WriteLine("PostExecute");
        }
        protected void Application_ReleaseRequestState()
        {
            // fires before current state data kept in the session collection is serialized.
        }
        protected void Application_UpdateRequestCache()
        {
            // fires before information is added to output cache of the page.
        }
        protected void Application_EndRequest()
        {
            // fires at the end of each request - finished processing request
        }

    }
}
