using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExelTools.Startup))]
namespace ExelTools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
