using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HosterPKDeployTest.Startup))]
namespace HosterPKDeployTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
