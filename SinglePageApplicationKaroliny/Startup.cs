using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SinglePageApplicationKaroliny.Startup))]
namespace SinglePageApplicationKaroliny
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
