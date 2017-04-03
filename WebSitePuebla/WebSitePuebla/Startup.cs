using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSitePuebla.Startup))]
namespace WebSitePuebla
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
