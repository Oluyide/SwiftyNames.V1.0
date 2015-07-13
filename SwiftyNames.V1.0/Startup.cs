using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwiftyNames.V1._0.Startup))]
namespace SwiftyNames.V1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
