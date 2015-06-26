using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPageLifeCycle.Startup))]
namespace MVCPageLifeCycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
