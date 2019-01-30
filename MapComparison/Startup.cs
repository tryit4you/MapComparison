using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapComparison.Startup))]
namespace MapComparison
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
