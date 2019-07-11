using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsIntegration.Startup))]
namespace JenkinsIntegration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
