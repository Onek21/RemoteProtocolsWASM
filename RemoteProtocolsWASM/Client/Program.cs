using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Radzen;
using RemoteProtocolsWASM.Client.Application.Interfaces;
using RemoteProtocolsWASM.Client.Application.Interfaces.XLInterfaces;
using RemoteProtocolsWASM.Client.Application.Services;
using RemoteProtocolsWASM.Client.Application.Services.XLServices;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("RemoteProtocolsWASM.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("RemoteProtocolsWASM.ServerAPI"));

            builder.Services.AddApiAuthorization()
                .AddAccountClaimsPrincipalFactory<CustomUserFactory>();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddScoped<NotificationService>();
            builder.Services.AddScoped<TooltipService>();
            builder.Services.AddScoped<ContextMenuService>();

            builder.Services.AddHttpClient<ICarService, CarService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44309/");
            });

            builder.Services.AddHttpClient<IEventService, EventService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44309/");
            });

            builder.Services.AddHttpClient<IGroupService, GroupService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44309/");
            });

            builder.Services.AddHttpClient<ILocationService, LocationService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44309/");
            });

            builder.Services.AddHttpClient<IProjectService, ProjectService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44309/");
            });

            await builder.Build().RunAsync();
        }
    }
}
