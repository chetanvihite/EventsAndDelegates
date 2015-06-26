using MVCPageLifeCycle.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MVCPageLifeCycle.Modules
{
    public class RedirectModule : IHttpModule
    {
        public void Dispose()
        {
           
        }

        private HttpApplication _contenxt;

        public void Init(HttpApplication context)
        {
            _contenxt = context;
            context.MapRequestHandler += context_MapRequestHandler;
           
        }

        void context_MapRequestHandler(object sender, EventArgs e)
        {
            RedirectSection section = (RedirectSection)WebConfigurationManager.GetSection("redirects");
            foreach (Redirect redirect in section.Redirects)
            {
                if (redirect.Old == _contenxt.Request.RequestContext.HttpContext.Request.RawUrl)
                {
                    _contenxt.Response.Redirect(redirect.New);
                }
            }
        }
    }
}