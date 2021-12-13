using Automat.Client.BlazorDTOs;
using Automat.Client.Clients.Interfaces;
using Automat.Client.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Services
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
