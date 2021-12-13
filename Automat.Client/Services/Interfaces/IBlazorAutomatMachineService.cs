using Automat.Client.BlazorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Services.Interfaces
{
    public interface IBlazorAutomatMachineService
    {
        Task<IEnumerable<BlazorAutomatMachineDTO>> GetAutomatMachines();
        Task<BlazorAutomatMachineDTO> GetAutomatMachineById(int id);
        Task<bool> CreateAutomatMachine(BlazorAutomatMachineDTO automatMachine);
        Task<bool> UpdateAutomatMachine(int automatId, BlazorAutomatMachineDTO automatMachine);
        Task<bool> DeleteAutomatMachine(int id);
    }
}
