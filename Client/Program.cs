using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.Toast;
using MudBlazor.Services;
using Blazor.Client.Clients.Interfaces;
using Blazor.Client.Clients;
using Blazor.Client.Services.Interfaces;
using Blazor.Client.Services;
using Blazor.Client.ViewModels;

namespace Blazor.Client
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

            builder.Services.AddHttpClient<IProductClient, ProductClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorProductsService, BlazorProductsService>();

            builder.Services.AddHttpClient<IServiceManClient, ServiceManClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorServiceMenService, BlazorServiceMenService>();

            builder.Services.AddHttpClient<IDiscountCardClient, DiscountCardClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorDiscountCardsService, BlazorDiscountCardsService>();

            builder.Services.AddHttpClient<ICompositionClient, CompositionClient>(client => client.BaseAddress = new Uri("https://localhost:44356/api/"));
            builder.Services.AddSingleton<IBlazorCompositionService, BlazorCompositionService>();


            builder.Services.AddMudServices();


            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped(sp =>
                new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            LoadHttpClients(builder);
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            
         

            builder.Services.AddBlazoredToast();

            await builder.Build().RunAsync();
        }

        public static void LoadHttpClients(WebAssemblyHostBuilder builder)
        {          

            builder.Services.AddHttpClient<ILoginViewModel, LoginViewModel>
                ("BlazorClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            
            builder.Services.AddHttpClient<IRegisterViewModel, RegisterViewModel>
                ("BlazorClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));






        }
    }
}
