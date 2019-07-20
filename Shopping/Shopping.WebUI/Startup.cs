using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shopping.WebUI.Startup))]
namespace Shopping.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
