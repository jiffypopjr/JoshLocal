using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample.App.Web.Startup))]
namespace Sample.App.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
