using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dana_Desa_App.Startup))]
namespace Dana_Desa_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
