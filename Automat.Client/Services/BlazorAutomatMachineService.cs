using Automat.Client.BlazorDTOs;
using Automat.Client.Clients.Interfaces;
using Automat.Client.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Services
{
    public class BlazorAutomatMachineService : IBlazorAutomatMachineService
    {
        private readonly IAutomatMachineClient _automatMachineClient;
        public BlazorAutomatMachineService(IAutomatMachineClient automatMachineClient)
        {
            _automatMachineClient = automatMachineClient;
        }

        public async Task<IEnumerable<BlazorAutomatMachineDTO>> GetAutomatMachines()
        {
            return await _automatMachineClient.GetAllItems();
        }

        public async Task<BlazorAutomatMachineDTO> GetAutomatMachineById(int id)
        {
            return await _automatMachineClient.GetById(id);
        }

        public async Task<bool> CreateAutomatMachine(BlazorAutomatMachineDTO automat)
        {
            return await _automatMachineClient.Create(automat);
        }

        public async Task<bool> DeleteAutomatMachine(int automatid)
        {
            return await _automatMachineClient.Delete(automatid);
        }

        public async Task<bool> UpdateAutomatMachine(int automatId, BlazorAutomatMachineDTO automat)
        {
            return await _automatMachineClient.Update(automatId, automat);
        }

    }
}
