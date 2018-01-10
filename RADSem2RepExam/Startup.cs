using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RADSem2RepExam.Startup))]
namespace RADSem2RepExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
