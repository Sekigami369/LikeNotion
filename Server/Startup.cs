using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using LikeNotion.Server.Hubs;

namespace LikeNotion.Server
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<SharedDocumentHub>("/sharedDocumentHub");
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });   
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }


    }
}
