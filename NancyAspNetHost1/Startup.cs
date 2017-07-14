
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NancyAspNetHost1.Startup))]

namespace NancyAspNetHost1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            NancyAspNetHost.SignalR.StockTicker.Startup.ConfigureSignalR(app);
        }
    }
}
