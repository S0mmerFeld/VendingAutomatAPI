using Automat.Blazor.BlazorDTOs;
using Automat.Blazor.Infrastructure.HttpClients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Blazor.Infrastructure.HttpClients.Interfaces
{
    public interface IAutomatMachineClient : IGenericClient<BlazorAutomatMachineDTO>
    {
    }
}
