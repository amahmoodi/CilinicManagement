using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CilinicManagment.Startup))]
namespace CilinicManagment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
