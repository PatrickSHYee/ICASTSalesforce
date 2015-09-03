using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICASTSalesforce.Startup))]
namespace ICASTSalesforce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
