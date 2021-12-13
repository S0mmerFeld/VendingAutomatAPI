using System;
using Automat.HttpClient.Areas.Identity.Data;
using Automat.HttpClient.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Automat.HttpClient.Areas.Identity.IdentityHostingStartup))]
namespace Automat.HttpClient.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AutomatHttpClientContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AutomatHttpClientContextConnection")));

               

               
            });
        }
    }
}