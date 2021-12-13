using Blazor.Client.BlazorDTOs;
using Blazor.Client.Clients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor.Client.Clients
{
    public class DiscountCardClient : GenericClient<BlazorDiscountCardDTO>, IDiscountCardClient
    {
        public DiscountCardClient(HttpClient client) : base(client, "DiscountCard") { }
    }
}
