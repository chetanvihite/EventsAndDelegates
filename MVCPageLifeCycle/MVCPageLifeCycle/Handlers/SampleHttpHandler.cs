using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPageLifeCycle.Handlers
{
    public abstract class Calculator<T>
    {
        public abstract int Add(T a, T b);        
    }

    public class Dervived : Calculator<int>
    {
        public override int Add(int a, int b)
        {            
            return a + b;
        }
    }

    public class SampleHttpHandler:  IHttpHandler
    {
        public bool IsReusable { get { return false; } }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<b>this is the response from HttpHandler</b>");
        }
    }
}