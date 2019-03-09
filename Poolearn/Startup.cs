using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Poolearn.Startup))]
namespace Poolearn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
