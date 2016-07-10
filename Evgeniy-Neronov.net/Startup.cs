using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Evgeniy_Neronov.net.Startup))]
namespace Evgeniy_Neronov.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
