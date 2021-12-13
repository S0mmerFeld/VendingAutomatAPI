using Automat.Blazor.DTOs;
using Automat.Blazor.Infrastructure.HttpClients.Interfaces;
using Automat.Blazor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Blazor.Services
{
    public class CarService : ICarService
    {
        private readonly ICarClient _carClient;
        public CarService(ICarClient carClient)
        {
            _carClient = carClient;
        }

        public Task<CarDTO> GetCarById(int id)
        {
            return _carClient.GetById(id);
        }

        public async Task<IEnumerable<CarDTO>> GetCars()
        {
            return await _carClient.GetAll();
        }
    }
}
