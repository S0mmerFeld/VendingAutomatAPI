using Automat.Blazor.BlazorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Blazor.Services.Interfaces
{
    public interface IBlazorAutomatMachineService
    {
        Task<IEnumerable<BlazorAutomatMachineDTO>> GetAutomatMachines();
        Task<BlazorAutomatMachineDTO> GetAutomatMachineById(int id);
    }
}
