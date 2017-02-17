using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(javascriptBasic.Startup))]
namespace javascriptBasic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
