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
    public class SoldsClient : GenericClient<BlazorSoldsDTO>, ISoldsClient
    {
        public SoldsClient(HttpClient client) : base(client, "solds") { }
    }
}
