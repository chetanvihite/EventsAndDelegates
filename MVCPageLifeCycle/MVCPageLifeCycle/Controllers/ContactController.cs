﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPageLifeCycle.Controllers
{
    public class ContactController : IController
    {
        public ContactController(ILoggingService logging)
        {

        }

        public void Execute(System.Web.Routing.RequestContext requestContext)
        {
            HttpContext.Current.Response.Write("This was genrated by custom controller");
        }
    }
}