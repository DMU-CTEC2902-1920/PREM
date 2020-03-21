using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBookProject.Startup))]
namespace MVCBookProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
