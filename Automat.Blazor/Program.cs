using Automat.Blazor.Infrastructure.HttpClients;
using Automat.Blazor.Infrastructure.HttpClients.Interfaces;
using Automat.Blazor.Services;
using Automat.Blazor.Services.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddHttpClient<IAutomatMachineClient, AutomatMachineClient>(client =>
                                                          client.BaseAddress = new Uri("https://localhost:44356/api/"));
            
            builder.Services.AddScoped<IBlazorAutomatMachineService, BlazorAutomatMachineService>();


            await builder.Build().RunAsync();
        }
    }
}
