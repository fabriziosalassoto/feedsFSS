using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(feedsFSS.Startup))]
namespace feedsFSS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
