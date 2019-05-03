using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CosplayShop.Startup))]
namespace CosplayShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
