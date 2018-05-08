using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMSApplication.Startup))]
namespace AMSApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
