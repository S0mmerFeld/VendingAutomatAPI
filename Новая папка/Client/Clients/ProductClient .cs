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
    public class ProductClient : GenericClient<BlazorProductDTO>, IProductClient
    {
        public ProductClient(HttpClient client) : base(client, "Product") { }
    }
}
