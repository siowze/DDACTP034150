using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDACTP034150.Startup))]
namespace DDACTP034150
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
