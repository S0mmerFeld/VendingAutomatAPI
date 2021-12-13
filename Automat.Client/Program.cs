using Automat.Client.Clients;
using Automat.Client.Clients.Interfaces;
using Automat.Client.Services;
using Automat.Client.Services.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MudBlazor.Services;

namespace Automat.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddHttpClient<IAutomatMachineClient, AutomatMachineClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorAutomatMachineService, BlazorAutomatMachineService>();

            builder.Services.AddHttpClient<ISoldsClient, SoldsClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorSoldsService, BlazorSoldsService>();

            builder.Services.AddHttpClient<IProductClient , ProductClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorProductsService, BlazorProductsService>();

            builder.Services.AddHttpClient<IServiceManClient , ServiceManClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorServiceMenService , BlazorServiceMenService>();

            builder.Services.AddHttpClient<IDiscountCardClient, DiscountCardClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorDiscountCardsService, BlazorDiscountCardsService>();

            builder.Services.AddHttpClient<ICompositionClient, CompositionClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorCompositionService, BlazorCompositionService>();


            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }
}
