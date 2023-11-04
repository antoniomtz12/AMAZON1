using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMAZON1.Startup))]
namespace AMAZON1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
