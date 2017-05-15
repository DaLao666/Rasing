using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rasing.Startup))]
namespace Rasing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
