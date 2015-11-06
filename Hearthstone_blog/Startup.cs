using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hearthstone_blog.Startup))]
namespace Hearthstone_blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
