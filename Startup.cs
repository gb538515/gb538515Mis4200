using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gb538515Mis4200.Startup))]
namespace gb538515Mis4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
