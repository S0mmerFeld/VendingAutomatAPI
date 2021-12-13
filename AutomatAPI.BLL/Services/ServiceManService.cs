using Automat.BLL.Exceptions;
using Automat.DAL.Context;
using AutomatAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.DAL.Repositories
{
    public class ServiceManService : IGenericService<ServiceMan>, IServiceManService
    {
        private readonly ProductContext _context;
        public ServiceManService(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceMan>> GetAllAsync()
        {
            var records = await _context.ServiceMan.Select(x => new ServiceMan()
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                SMCard = x.SMCard
            }).ToListAsync();

            if (records == null)
                throw new ItemNotFoundException($"{typeof(ServiceMan).Name} could not found.");

            return records;
        }


        public async Task<ServiceMan> GetByIdAsync(int servicemanId)
        {
            var servicemen = await _context.ServiceMan.Where(x => x.Id == servicemanId).Select(x => new ServiceMan()
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                SMCard = x.SMCard

            }).FirstOrDefaultAsync();

            if (servicemen == null)
                throw new ItemNotFoundException($"{typeof(ServiceMan).Name} item with id {servicemanId} not found.");

            return servicemen;
        }

        public async Task<ServiceMan> AddAsync(ServiceMan serviceManModel)
        {
            var serviceMan = new ServiceMan()
            {
                Id = serviceManModel.Id,
                Name = serviceManModel.Name,
                Surname = serviceManModel.Surname,
                SMCard = serviceManModel.SMCard
            };

            _context.ServiceMan.Add(serviceMan);

            await _context.SaveChangesAsync();
            return serviceMan;

        }

        public async Task UpdateAsync(int serviceManId, ServiceMan serviceManIdModel)
        {
            var serviceMan = await _context.ServiceMan.FindAsync(serviceManId);
            if (serviceMan != null)
            {
                serviceMan.Name = serviceManIdModel.Name;
                serviceMan.Surname = serviceManIdModel.Surname;
                serviceMan.SMCard = serviceManIdModel.SMCard;

                await _context.SaveChangesAsync();
            }

        }

        public async Task DeleteAsync(int serviceManId)
        {            
            var serviceMan = await GetByIdAsync(serviceManId);
            if (serviceMan == null)
                throw new ItemNotFoundException($"{typeof(AutomatMachine).Name} with id {serviceManId} not found");
            _context.ServiceMan.Remove(serviceMan);

            await _context.SaveChangesAsync();
        }



        public async Task AddProducts(string productname, int quantity)
        {

            var products = await _context.Product
                 .Where(x => x.Name == productname)
                 .Select(g => new
                 {
                     id = g.Id,
                     CurrentQuantity = g.CurrentQuantity
                 })
                 .ToListAsync();

            var product = await _context.Product.FindAsync(products[0].id);

            if (products.Count != 0)
            {
                product.CurrentQuantity = products[0].CurrentQuantity;
                product.CurrentQuantity += quantity;

                await _context.SaveChangesAsync();
            }

        }



    }
}
