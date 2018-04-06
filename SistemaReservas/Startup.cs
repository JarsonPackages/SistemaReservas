using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SistemaReservas.Startup))]
namespace SistemaReservas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
