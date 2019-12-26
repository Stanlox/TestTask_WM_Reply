using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WM_Reply.Startup))]
namespace WM_Reply
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
