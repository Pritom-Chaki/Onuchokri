using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Onuchokri.Startup))]
namespace Onuchokri
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
