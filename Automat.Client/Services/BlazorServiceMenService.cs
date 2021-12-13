using Automat.Client.BlazorDTOs;
using Automat.Client.Clients.Interfaces;
using Automat.Client.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Services
{
    public class BlazorServiceMenService : IBlazorServiceMenService
    {
        private readonly IServiceManClient _iServiceMan;
        public BlazorServiceMenService(IServiceManClient iServiceManClient)
        {
            _iServiceMan = iServiceManClient;
        }

        public async Task<IEnumerable<BlazorServiceManDTO>> GetServiceMen()
        {
            return await _iServiceMan.GetAllItems();        }

        public async Task<BlazorServiceManDTO> GetServiceManById(int id)
        {
            return await _iServiceMan.GetById(id);
        }

        public async Task<bool> CreateServiceMan(BlazorServiceManDTO serviceman)
        {
            return await _iServiceMan.Create(serviceman);
        }

        public async Task<bool> DeleteServiceMan(int servicemanid)
        {
            return await _iServiceMan.Delete(servicemanid);
        }

        public async Task<bool> UpdateServiceMan(int servicemanid, BlazorServiceManDTO serviceman)
        {
            return await _iServiceMan.Update(servicemanid, serviceman);
        }




    }
}
