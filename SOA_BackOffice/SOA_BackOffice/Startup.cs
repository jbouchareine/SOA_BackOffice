using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOA_BackOffice.Startup))]
namespace SOA_BackOffice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
