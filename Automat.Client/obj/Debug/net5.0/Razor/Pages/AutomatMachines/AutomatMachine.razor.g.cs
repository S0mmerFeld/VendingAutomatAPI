#pragma checksum "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ac348e1a9169530c745eb72e0495b0152663b2"
// <auto-generated/>
#pragma warning disable 1591
namespace Automat.Client.Pages.AutomatMachines
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
#line 2 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
using Automat.Client.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
using Automat.Client.BlazorDTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AutomatMachine/{id:int}")]
    public partial class AutomatMachine : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AutomatMachine</h3>");
#nullable restore
#line 11 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
 if (Automat == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<span><em>Loading...</em></span>");
#nullable restore
#line 13 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                                 }

else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Id</th>\n            <th>InventoryId</th>\n            <th>Name</th>\n            <th>Address</th>\n            <th>MaxProductNum</th>\n            <th>CurrentProdNumber</th></tr></thead>\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 32 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                 Automat.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 33 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                 Automat.InventoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 34 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                 Automat.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 35 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                 Automat.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 36 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                 Automat.MaxProductNum

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 37 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                 Automat.CurrentProdNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<MudBlazor.MudButton>(24);
            __builder.AddAttribute(25, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 44 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                        Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                                                    Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 44 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                                                                                       Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                                                                                                                   ()=>EditAutomatMachine(Automat.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(30, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\n    ");
            __builder.OpenComponent<MudBlazor.MudButton>(32);
            __builder.AddAttribute(33, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 45 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                        Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                                                    Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 45 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                                                                                         Color.Error

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
                                                                                                                  ()=> DeleteAutomatMachine(Automat.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(38, "Delete");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 46 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
   

    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\AutomatMachines\AutomatMachine.razor"
  [Parameter]
        public int Id { get; set; }

        BlazorAutomatMachineDTO Automat;
        //ClientDTO carOwner;

        protected override async Task OnInitializedAsync()
    {
        Automat = await BlazorAutomatMachineService.GetAutomatMachineById(Id);
        //if (AutomatMachine.ClientId.HasValue) carOwner = await BlazorAutomatMachineService.GetClientById(car.ClientId.GetValueOrDefault());
    }

    void EditAutomatMachine(int id)
    {
        NavigationManager.NavigateTo($"/editAutomatMachine/{id}");
    }

    async Task DeleteAutomatMachine(int id)
    {
        var result = await BlazorAutomatMachineService.DeleteAutomatMachine(id);
        if (result) NavigationManager.NavigateTo($"/AutomatMachines");
    }

    void ShowClient(int? id)
    {
        NavigationManager.NavigateTo($"/Automatmachine/{id}");
    } 
        
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorSoldsService BlazorSoldsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorAutomatMachineService BlazorAutomatMachineService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591