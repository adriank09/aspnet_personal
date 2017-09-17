using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdrianKhor.Startup))]
namespace AdrianKhor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
