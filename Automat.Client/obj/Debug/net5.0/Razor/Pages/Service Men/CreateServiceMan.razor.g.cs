#pragma checksum "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eed8d6cda25c0755d5d9510d9c17d9431f96c9a7"
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
#line 2 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor"
using Automat.Client.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor"
using Automat.Client.BlazorDTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createServiceMan")]
    public partial class CreateServiceMan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateServiceMan</h3>\n\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor"
                  serviceman

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor"
                                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label for=\"Name\" class=\"form-label\">Name</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Name", "Name");
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor"
                                             serviceman.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceman.Name = __value, serviceman.Name))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => serviceman.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __Blazor.Automat.Client.Pages.Service_Men.CreateServiceMan.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 18 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor"
                                  ()=>serviceman.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"Name\" class=\"form-label\">Surname</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "Name", "Name");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor"
                                             serviceman.Surname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => serviceman.Surname = __value, serviceman.Surname))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => serviceman.Surname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\n        ");
                __Blazor.Automat.Client.Pages.Service_Men.CreateServiceMan.TypeInference.CreateValidationMessage_1(__builder2, 30, 31, 
#nullable restore
#line 24 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor"
                                  ()=>serviceman.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n\n\n    ");
                __builder2.AddMarkupContent(33, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Pages\Service Men\CreateServiceMan.razor"
       

    BlazorServiceManDTO serviceman = new BlazorServiceManDTO();

    async Task HandleValidSubmit()
    {
        var result = await BlazorServiceMenService.CreateServiceMan(serviceman);
        if (result)
        {
            NavigationManager.NavigateTo("/ServiceMen");
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorServiceMenService BlazorServiceMenService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Automat.Client.Pages.Service_Men.CreateServiceMan
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591