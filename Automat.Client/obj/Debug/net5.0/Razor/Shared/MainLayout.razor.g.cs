#pragma checksum "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d714885ccd1d84626ecaf90abc176dc3431b78e5"
// <auto-generated/>
#pragma warning disable 1591
namespace Automat.Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-o22zzna2h4");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "background-image: none; background-color: none;");
            __builder.AddAttribute(5, "class", "sidebar");
            __builder.AddAttribute(6, "b-o22zzna2h4");
            __builder.OpenComponent<Automat.Client.Shared.NavMenu>(7);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main");
            __builder.AddAttribute(11, "b-o22zzna2h4");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-12");
            __builder.AddAttribute(14, "b-o22zzna2h4");
            __builder.OpenComponent<MudBlazor.MudCarousel<object>>(15);
            __builder.AddAttribute(16, "Style", "height:200px;");
            __builder.AddAttribute(17, "ShowArrows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                        arrows

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ShowDelimiters", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                                                 delimiters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "AutoCycle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                                                                         autocycle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(21);
                __builder2.AddAttribute(22, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 14 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                         transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 14 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                             Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(25, "div");
                    __builder3.AddAttribute(26, "class", "d-flex");
                    __builder3.AddAttribute(27, "style", "height:100%");
                    __builder3.AddAttribute(28, "b-o22zzna2h4");
                    __builder3.OpenComponent<MudBlazor.MudCardMedia>(29);
                    __builder3.AddAttribute(30, "Image", "D:/Users/Олег/source/repos/AutomatAP/\\AutomatAPI/Automat.Client/wwwroot/Images/IMG_20190706_123815.png");
                    __builder3.AddAttribute(31, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                                                                                                                         200

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n                            ");
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(33);
                __builder2.AddAttribute(34, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 19 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                         transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                             Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "class", "d-flex");
                    __builder3.AddAttribute(39, "style", "height:100%");
                    __builder3.AddAttribute(40, "b-o22zzna2h4");
                    __builder3.OpenComponent<MudBlazor.MudIcon>(41);
                    __builder3.AddAttribute(42, "Class", "mx-auto my-auto");
                    __builder3.AddAttribute(43, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                            Icons.Custom.Brands.Facebook

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 21 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                                                                 Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n                            ");
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(46);
                __builder2.AddAttribute(47, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 24 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                         transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "class", "d-flex");
                    __builder3.AddAttribute(51, "style", "height:100%");
                    __builder3.AddAttribute(52, "b-o22zzna2h4");
                    __builder3.OpenComponent<MudBlazor.MudIcon>(53);
                    __builder3.AddAttribute(54, "Class", "mx-auto my-auto");
                    __builder3.AddAttribute(55, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                            Icons.Custom.Brands.GitHub

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                                                                Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 26 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                                                                                                                                      Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n            \n\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "content px-4");
            __builder.AddAttribute(61, "b-o22zzna2h4");
            __builder.AddContent(62, 
#nullable restore
#line 34 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n\n\n\n\n\n\n");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(64);
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(66);
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(68);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\MainLayout.razor"
      
    private bool arrows = true;
    private bool delimiters = true;
    private bool autocycle = true;
    public Transition transition = Transition.Slide;





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
