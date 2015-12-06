using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComponentsLife.Startup))]
namespace ComponentsLife
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
