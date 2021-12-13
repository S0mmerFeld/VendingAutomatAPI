using Automat.Blazor.BlazorDTOs;
using Automat.Blazor.Infrastructure.HttpClients.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Automat.Blazor.Infrastructure.HttpClients
{
    public class AutomatMachineClient : GenericClient<BlazorAutomatMachineDTO>, IAutomatMachineClient
    {
        public AutomatMachineClient(HttpClient client) : base(client, "automatMachine") { }
    }
}
