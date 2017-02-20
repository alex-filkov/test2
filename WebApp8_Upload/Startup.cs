using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp8_Upload.Startup))]
namespace WebApp8_Upload
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
