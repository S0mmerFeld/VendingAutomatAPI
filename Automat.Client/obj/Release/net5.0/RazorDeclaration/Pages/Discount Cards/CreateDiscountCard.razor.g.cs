// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Automat.Client.Pages.Discount_Cards
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
#line 2 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\Pages\Discount Cards\CreateDiscountCard.razor"
using Automat.Client.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\Pages\Discount Cards\CreateDiscountCard.razor"
using Automat.Client.BlazorDTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/creatediscountcard")]
    public partial class CreateDiscountCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Users\o.evseenko\Source\Repos\VendingAutomatAPI\Automat.Client\Pages\Discount Cards\CreateDiscountCard.razor"
       

    BlazorDiscountCardDTO DiscountCard = new BlazorDiscountCardDTO();

    async Task HandleValidSubmit()
    {
        var result = await BlazorDiscountCardsService.CreateDiscountCard(DiscountCard);
        if (result)
        {
            NavigationManager.NavigateTo("/DiscountCards");
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorDiscountCardsService BlazorDiscountCardsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
