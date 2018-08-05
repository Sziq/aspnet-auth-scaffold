using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PPJWAug.Startup))]
namespace PPJWAug
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
