using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorBuddy.Startup))]
namespace TutorBuddy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
