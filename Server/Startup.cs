using Microsoft.AspNetCore.Routing;

namespace LikeNotion.Server
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // ...

            ConfigureEndpoints(app);
        }

        private void ConfigureEndpoints(IApplicationBuilder app)
        {
            var endpointRouteBuilder = new EndpointRouteBuilder(app);
            endpointRouteBuilder.MapHub<SharedDocumentHub>("/sharedDocumentHub");
            endpointRouteBuilder.MapBlazorHub();
            endpointRouteBuilder.MapFallbackToPage("/_Host");

            var endpoints = endpointRouteBuilder.DataSources;
            app.UseEndpoints(endpoints);
        }

    }
}
