using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JKCS.SM.Web.Startup))]
namespace JKCS.SM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
