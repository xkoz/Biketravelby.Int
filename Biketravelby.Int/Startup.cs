using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Biketravelby.Int.Startup))]
namespace Biketravelby.Int
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
