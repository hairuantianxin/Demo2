using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5demo2.Startup))]
namespace Mvc5demo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
