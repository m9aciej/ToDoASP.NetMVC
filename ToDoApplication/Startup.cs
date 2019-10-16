using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoApplication.Startup))]
namespace ToDoApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
