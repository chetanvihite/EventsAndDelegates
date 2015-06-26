using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Web.SessionState;
namespace MVCPageLifeCycle.Controllers
{
    public class Logger : ILoggingService
    { 
    }
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            var logger = new Logger();

            if (controllerName == "contact")
            {
                return new ContactController(logger);
            }            
            // returning HomeController for demo purposes, in other cases you would 
            //have to add logic to instantiate other controllers depending upon context and contollerName
            return new HomeController(); 
        }
        public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, 
            string controllerName)
        {
            return SessionStateBehavior.Default; // use the default session state for demo purpose
        }
        public void ReleaseController(IController controller)
        {
            // do nothing, as we dont have any resources to free up
        }
    }
}