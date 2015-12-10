using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SonicBliss.Startup))]
namespace SonicBliss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
