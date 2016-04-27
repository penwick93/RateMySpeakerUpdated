using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RateMySpeaker.Startup))]
namespace RateMySpeaker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
