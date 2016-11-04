using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Olbp.Startup))]
namespace Olbp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
