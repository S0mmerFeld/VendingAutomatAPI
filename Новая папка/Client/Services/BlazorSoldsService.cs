using Blazor.Client.BlazorDTOs;
using Blazor.Client.Clients.Interfaces;
using Blazor.Client.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Client.Services
{
    public class BlazorSoldsService : IBlazorSoldsService
    {
        private readonly ISoldsClient _iSoldsClient;
        public BlazorSoldsService(ISoldsClient iSoldsClient)
        {
            _iSoldsClient = iSoldsClient;
        }

        public async Task<IEnumerable<BlazorSoldsDTO>> GetSolds()
        {
            return await _iSoldsClient.GetAllItems();
        }
    }
}
