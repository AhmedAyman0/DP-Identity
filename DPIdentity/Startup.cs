using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DPIdentity.Startup))]
namespace DPIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
