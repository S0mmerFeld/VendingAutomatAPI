#pragma checksum "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de1c54625a353dd9437d559ea181b9fd24c9eae"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudPaper>(0);
            __builder.AddAttribute(1, "Width", "250px");
            __builder.AddAttribute(2, "Class", "d-inline-flex py-3");
            __builder.AddAttribute(3, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavMenu>(5);
                __builder2.AddAttribute(6, "Class", "mud-width-full");
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDivider>(8);
                    __builder3.AddAttribute(9, "Class", "my-2");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\n         ");
                    __builder3.OpenComponent<MudBlazor.MudText>(11);
                    __builder3.AddAttribute(12, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 20 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                        Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Class", "px-4");
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(15, "Telemetry");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\n         ");
                    __builder3.OpenComponent<MudBlazor.MudText>(17);
                    __builder3.AddAttribute(18, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 21 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                        Typo.body2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Class", "px-4 mud-text-secondary");
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(21, "Automat Machines");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\n\n         ");
                    __builder3.OpenComponent<MudBlazor.MudDivider>(23);
                    __builder3.AddAttribute(24, "Class", "my-2");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\n\n         ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(26);
                    __builder3.AddAttribute(27, "Href", "/AutomatMachines");
                    __builder3.AddAttribute(28, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                                    Icons.Filled.Mail

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(30, "AutomatMachines");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n\n\n         ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(32);
                    __builder3.AddAttribute(33, "Href", "/Solds");
                    __builder3.AddAttribute(34, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                          Icons.Filled.Money

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(36, "Solds");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n         ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(38);
                    __builder3.AddAttribute(39, "Href", "/Products");
                    __builder3.AddAttribute(40, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                             Icons.Filled.Money

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(42, "Pie Chart");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n         ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(44);
                    __builder3.AddAttribute(45, "Href", "/DiscountCards");
                    __builder3.AddAttribute(46, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                                  Icons.Filled.Money

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(48, "Bar Chart");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n\n\n         ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(50);
                    __builder3.AddAttribute(51, "Href", "/Products");
                    __builder3.AddAttribute(52, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                             Icons.Filled.BreakfastDining

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(54, "Products");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n         ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(56);
                    __builder3.AddAttribute(57, "Href", "/Servicemen");
                    __builder3.AddAttribute(58, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                               Icons.Filled.People

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 34 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                                                               Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(61, "Servicemen");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n         ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(63);
                    __builder3.AddAttribute(64, "Href", "/DiscountCards");
                    __builder3.AddAttribute(65, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                                  Icons.Filled.CardGiftcard

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(67, "DiscountCards");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n         ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(69);
                    __builder3.AddAttribute(70, "Href", "/API");
                    __builder3.AddAttribute(71, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
                                        Icons.Filled.Api

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(73, "API");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Олег\Downloads\AutomatWebAPI-master\AutomatWebAPI-master\Automat.Client\Shared\NavMenu.razor"
        private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
