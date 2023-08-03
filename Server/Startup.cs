using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;
using LikeNotion.Server.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace LikeNotion.Server
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<SharedDocuHub>("/sharedDocumentHub");
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
            /*
             *  var endpointRouteBuilder = new EndpointRouteBuilder(app);
                endpointRouteBuilder.MapHub<SharedDocumentHub>("/sharedDocumentHub");
                endpointRouteBuilder.MapBlazorHub();
                endpointRouteBuilder.MapFallbackToPage("/_Host");

                var endpoints = endpointRouteBuilder.DataSources;
                app.UseEndpoints(endpoints);
                ラムダ式で書かなかった場合の書き方
                
                */

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }
    }
}
