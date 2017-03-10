using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(egifter_test.Startup))]
namespace egifter_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
