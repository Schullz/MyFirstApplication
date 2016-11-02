using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstApplication.Startup))]
namespace MyFirstApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
