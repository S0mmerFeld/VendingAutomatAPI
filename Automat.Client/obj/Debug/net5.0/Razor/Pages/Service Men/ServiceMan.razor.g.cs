#pragma checksum "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8d40b226f973bab7283f5e66d8e9169ea0fcd6"
// <auto-generated/>
#pragma warning disable 1591
namespace Automat.Client.Pages.Service_Men
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
#line 2 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
using Automat.Client.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
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
            __builder.AddMarkupContent(0, "<h3>ServiceMan</h3>");
#nullable restore
#line 11 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
 if (serviceman == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<span><em>Loading...</em></span>");
#nullable restore
#line 13 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
                                     }

else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>id</th>\n                <th>Name</th>\n                <th>Price</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 28 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
                     serviceman.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 29 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
                     serviceman.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
                     serviceman.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-success");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
                                                ()=>EditServiceMan(serviceman.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-danger");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
                                               ()=> DeleteProduct(serviceman.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Delete");
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\ServiceMan.razor"
       

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
