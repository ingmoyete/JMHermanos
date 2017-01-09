using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JMHermanosMVC.Startup))]
namespace JMHermanosMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
