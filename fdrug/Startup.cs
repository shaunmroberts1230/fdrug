using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fdrug.Startup))]
namespace fdrug
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
