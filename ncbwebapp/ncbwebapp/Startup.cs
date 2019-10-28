using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ncbwebapp.Startup))]
namespace ncbwebapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
