using Automat.Client.BlazorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Services.Interfaces
{
    public interface IBlazorCompositionService
    {
        Task<IEnumerable<BlazorApiCompositionDTO>> GetAll();

        Task<IEnumerable<BlazorApiCompositionDTO>> GetInformationByName(string CompositionName);
    }
}
