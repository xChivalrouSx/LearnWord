using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnWord.Startup))]
namespace LearnWord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
