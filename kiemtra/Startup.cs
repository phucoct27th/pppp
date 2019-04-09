using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kiemtra.Startup))]
namespace kiemtra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
