using Blazor.Client.BlazorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Client.Services.Interfaces
{
    public interface IBlazorServiceMenService
    {
        Task<IEnumerable<BlazorServiceManDTO>> GetServiceMen();
        Task<BlazorServiceManDTO> GetServiceManById(int serviceManId);
        Task<bool> CreateServiceMan(BlazorServiceManDTO serviceMan);
        Task<bool> UpdateServiceMan(int serviceManId, BlazorServiceManDTO serviceMan);
        Task<bool> DeleteServiceMan(int serviceManId);

        Task<bool> Add_quantity(string name, int num, BlazorServiceManDTO serviceman);


    }
}
