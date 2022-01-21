// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Automat.Client.Pages.Service_Men
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using Automat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using Automat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\Pages\Service Men\ServiceMan.razor"
using Automat.Client.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\Pages\Service Men\ServiceMan.razor"
using Automat.Client.BlazorDTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ServiceMan/{id:int}")]
    public partial class ServiceMan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\Pages\Service Men\ServiceMan.razor"
       

    [Parameter]
    public int Id { get; set; }

    BlazorServiceManDTO serviceman;

    protected override async Task OnInitializedAsync()
    {
        serviceman = await BlazorServiceMenService.GetServiceManById(Id);

    }

    void EditServiceMan(int id)
    {
        NavigationManager.NavigateTo($"/editServiceMan/{id}");
    }

    async Task DeleteProduct(int id)
    {
        var result = await BlazorServiceMenService.DeleteServiceMan(id);
        if (result) NavigationManager.NavigateTo($"/ServiceMen");
    }

    void ShowClient(int? id)
    {
        NavigationManager.NavigateTo($"/ServiceMan/{id}");
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorServiceMenService BlazorServiceMenService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
