using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TercerParcial_Ortiz.Startup))]
namespace TercerParcial_Ortiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
