using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jpswebapp.Startup))]
namespace jpswebapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
