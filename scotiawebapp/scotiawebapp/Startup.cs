using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(scotiawebapp.Startup))]
namespace scotiawebapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
