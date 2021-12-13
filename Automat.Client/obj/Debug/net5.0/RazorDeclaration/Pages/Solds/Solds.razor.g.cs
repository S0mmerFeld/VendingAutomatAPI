// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Automat.Client.Pages.Solds
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using Automat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using Automat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Solds\Solds.razor"
using Automat.Client.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Solds\Solds.razor"
using Automat.Client.BlazorDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Solds\Solds.razor"
using Automat.Client.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Solds")]
    public partial class Solds : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Solds\Solds.razor"
       



    private IEnumerable<BlazorSoldsDTO> solds = new List<BlazorSoldsDTO>();
    private IEnumerable<BlazorProductDTO> products = new List<BlazorProductDTO>();

    public List<string> s = new List<string>();
    public ChartOptions Options = new ChartOptions();
    public float sum = 0;
    public float percentage;

    List<string> ProductNames = new List<string>();
    List<double> SellQuantity = new List<double>();

    public List<BarData> Bar = new List<BarData>();


    public List<ChartSeries> Series = new List<ChartSeries>();


    protected override async Task OnInitializedAsync()
    {
        solds = await BlazorSoldsService.GetSolds();
        products = await BlazorProductsService.GetProducts();

        sum = 0;
        for (int i = 0; i < products.Count(); i++)
        {
            ProductNames.Add(products.ElementAt(i).Name);
            SellQuantity.Add(products.ElementAt(i).Sells);
            sum += products.ElementAt(i).Sells;

            Bar.Add(new BarData() { Name = products.ElementAt(i).Name, Month = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, Number = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } });

        }


        for (int i = 0; i < solds.Count(); i++)
        {
            for (int j = 0; j < Bar.Count(); j++)
            {
                if (solds.ElementAt(i).Name == Bar.ElementAt(j).Name)
                {
                    Bar.ElementAt(j).Number[solds.ElementAt(i).SellsDateTime.Month - 1]++;
                }

            }
        }

        for (int i = 0; i < Bar.Count(); i++)
        {
            Series.Add(new ChartSeries() { Name = products.ElementAt(i).Name, Data = Bar.ElementAt(i).Number.Select(Convert.ToDouble).ToArray() });
        }



        StateHasChanged();
    }


    private int Index = -1; //default value cannot be 0 -> first selectedindex is 0.





    public string[] XAxisLabels = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorProductsService BlazorProductsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorSoldsService BlazorSoldsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
