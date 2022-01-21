// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Automat.Client.Pages.AutomatMachines
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
#line 2 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\Pages\AutomatMachines\EditAutomatMachine.razor"
using Automat.Client.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\Pages\AutomatMachines\EditAutomatMachine.razor"
using Automat.Client.BlazorDTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editautomatmachine/{id:int}")]
    public partial class EditAutomatMachine : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\Pages\AutomatMachines\EditAutomatMachine.razor"
       
    [Parameter]
    public int Id { get; set; }
    BlazorAutomatMachineDTO AutomatMachine = new BlazorAutomatMachineDTO();

    async Task HandleValidSubmit()
    {
        var result = await BlazorAutomatMachineService.UpdateAutomatMachine(Id, AutomatMachine);
        if (result) NavigationManager.NavigateTo($"/automatmachine/{Id}");
    }

    protected override async Task OnInitializedAsync()
    {
        AutomatMachine = await BlazorAutomatMachineService.GetAutomatMachineById(Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorAutomatMachineService BlazorAutomatMachineService { get; set; }
    }
}
#pragma warning restore 1591
