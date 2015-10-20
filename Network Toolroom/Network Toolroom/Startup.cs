using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Network_Toolroom.Startup))]
namespace Network_Toolroom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
