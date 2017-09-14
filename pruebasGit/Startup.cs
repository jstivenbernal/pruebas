using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebasGit.Startup))]
namespace pruebasGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
