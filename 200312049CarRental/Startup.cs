using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200312049CarRental.Startup))]
namespace _200312049CarRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
