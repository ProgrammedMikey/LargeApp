using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LargeApp.Startup))]
namespace LargeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
