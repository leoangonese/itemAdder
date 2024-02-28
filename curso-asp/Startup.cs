using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(curso_asp.Startup))]
namespace curso_asp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
