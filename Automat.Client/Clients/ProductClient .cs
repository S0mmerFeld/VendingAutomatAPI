﻿using Automat.Client.BlazorDTOs;
using Automat.Client.Clients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Automat.Client.Clients
{
    public class ProductClient : GenericClient<BlazorProductDTO>, IProductClient
    {
        public ProductClient(HttpClient client) : base(client, "Product") { }
    }
}