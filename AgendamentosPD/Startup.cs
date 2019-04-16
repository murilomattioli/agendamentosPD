using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgendamentosPD.Startup))]
namespace AgendamentosPD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
