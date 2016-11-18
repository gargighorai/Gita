using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gita.Startup))]
namespace Gita
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
