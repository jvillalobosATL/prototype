using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_mvc_website.Startup))]
namespace test_mvc_website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
