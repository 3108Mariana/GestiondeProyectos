using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestiondeProyectos.Startup))]
namespace GestiondeProyectos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
