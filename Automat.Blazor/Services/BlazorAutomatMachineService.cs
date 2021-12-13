using Automat.Blazor.BlazorDTOs;
using Automat.Blazor.Infrastructure.HttpClients.Interfaces;
using Automat.Blazor.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Blazor.Services
{
    public class BlazorAutomatMachineService : IBlazorAutomatMachineService
    {
        private readonly IAutomatMachineClient _automatMachineClient;
        public BlazorAutomatMachineService(IAutomatMachineClient automatMachineClient)
        {
            _automatMachineClient = automatMachineClient;
        }


        public Task<BlazorAutomatMachineDTO> GetAutomatMachineById(int id)
        {
            return _automatMachineClient.GetById(id);
        }

        public async Task<IEnumerable<BlazorAutomatMachineDTO>> GetAutomatMachines()
        {
            return await _automatMachineClient.GetAll();
        }
    }
}
