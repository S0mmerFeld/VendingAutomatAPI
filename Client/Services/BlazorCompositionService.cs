using Blazor.Client.BlazorDTOs;
using Blazor.Client.Clients.Interfaces;
using Blazor.Client.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Client.Services
{
    public class BlazorCompositionService : IBlazorCompositionService
    {
        private readonly ICompositionClient _iCompositionClient;
        public BlazorCompositionService(ICompositionClient iCompositionClient)
        {
            _iCompositionClient = iCompositionClient;
        }

        public async Task<IEnumerable<BlazorApiCompositionDTO>> GetAll()
        {
            return await _iCompositionClient.GetAllItems();
        }

        public async Task<IEnumerable<BlazorApiCompositionDTO>> GetInformationByName(string CompositionName)
        {
            return await _iCompositionClient.GetCompositionByProduct(CompositionName);
        }
    }
}
