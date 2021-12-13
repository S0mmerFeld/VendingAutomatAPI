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
    public class ServiceCardService : IGenericService<ServiceCard>, IServiceCardService
    {
        private readonly ProductContext _context;
        public ServiceCardService(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceCard>> GetAllAsync()
        {
            var serviceCards = await _context.ServiceCard.Select(x => new ServiceCard()
            {
                Id = x.Id,
                Discount = x.Discount

            }).ToListAsync();

            if (serviceCards == null)
                throw new ItemNotFoundException($"{typeof(ServiceCard).Name} could not found.");

            return serviceCards;
        }


        public async Task<ServiceCard> GetByIdAsync(int serviceCardId)
        {
            var records = await _context.ServiceCard.Where(x => x.Id == serviceCardId).Select(x => new ServiceCard()
            {
                Id = x.Id,
                Discount = x.Discount,

            }).FirstOrDefaultAsync();

            if (records == null)
                throw new ItemNotFoundException($"{typeof(ServiceCard).Name} item with id {serviceCardId} not found.");

            return records;
        }

        public async Task<ServiceCard> AddAsync(ServiceCard serviceCardModel)
        {
            var serviceCard = new ServiceCard()
            {
                Id = serviceCardModel.Id,
                Discount = serviceCardModel.Discount,
            };

            _context.ServiceCard.Add(serviceCard);


            await _context.SaveChangesAsync();
            return serviceCard;

        }

        public async Task UpdateAsync(int serviceCardId, ServiceCard serviceCardModel)
        {
            var serviceCard = await _context.ServiceCard.FindAsync(serviceCardId);
            if (serviceCard != null)
            {
                serviceCard.Discount = serviceCardModel.Discount;

                await _context.SaveChangesAsync();
            }

        }

        public async Task DeleteAsync(int serviceCardId)
        {            
            var serviceCard = await GetByIdAsync(serviceCardId);
            if (serviceCard == null)
                throw new ItemNotFoundException($"{typeof(AutomatMachine).Name} with id {serviceCardId} not found");
            _context.ServiceCard.Remove(serviceCard);

            await _context.SaveChangesAsync();
        }




    }
}
