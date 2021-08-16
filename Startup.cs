using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crud_dotnet.Startup))]
namespace crud_dotnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
