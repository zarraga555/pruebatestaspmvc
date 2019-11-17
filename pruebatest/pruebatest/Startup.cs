using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebatest.Startup))]
namespace pruebatest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
