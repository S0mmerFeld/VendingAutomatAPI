using Automat.Client.BlazorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Services.Interfaces
{
    public interface IBlazorServiceMenService
    {
        Task<IEnumerable<BlazorServiceManDTO>> GetServiceMen();
        Task<BlazorServiceManDTO> GetServiceManById(int serviceManId);
        Task<bool> CreateServiceMan(BlazorServiceManDTO serviceMan);
        Task<bool> UpdateServiceMan(int serviceManId, BlazorServiceManDTO serviceMan);
        Task<bool> DeleteServiceMan(int serviceManId);
        
        
    }
}
