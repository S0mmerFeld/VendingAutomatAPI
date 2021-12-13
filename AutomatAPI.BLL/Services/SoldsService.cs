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
    public class SoldsService : IGenericService<Solds>, ISoldsService
    {
        private readonly ProductContext _context;
        public SoldsService(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<Solds>> GetAllAsync()
        {
            var records = await _context.Solds.Select(x => new Solds()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,               
                PriceString = x.PriceString,
                Tax = x.Tax,               
                SellsDateTime = x.SellsDateTime

            }).ToListAsync();

            if (records == null)
                throw new ItemNotFoundException($"{typeof(Solds).Name} could not found.");

            return records;
        }

        public async Task<Solds> GetByIdAsync(int soldId)
        {
            var records = await _context.Solds.Where(x => x.Id == soldId).Select(x => new Solds()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                PriceString = x.PriceString,
                Tax = x.Tax,
                SellsDateTime = x.SellsDateTime

            }).FirstOrDefaultAsync();

            if (records == null)
                throw new ItemNotFoundException($"{typeof(Solds).Name} item with id {soldId} not found.");

            return records;
        }

        public async Task<Solds> AddAsync(Solds soldModel)
        {

            var products = await _context.Product
                 .Where(x => x.Name == soldModel.Name)
                 .Select(g => new
                 {
                     id = g.Id,
                     CurrentQuantity = g.CurrentQuantity
                 })
                 .ToListAsync();           

           
            var product = await _context.Product.FindAsync(products[0].id);
            product.CurrentQuantity = products[0].CurrentQuantity;
                
            if (product.CurrentQuantity !=0)
            {
                var sold = new Solds()
                {
                    Id = soldModel.Id,
                    Name = soldModel.Name,
                    Price = soldModel.Price,
                    Tax = soldModel.Tax,
                    PriceString = soldModel.Price.ToString(),
                    SellsDateTime = soldModel.SellsDateTime
                };
                
                if(product.CurrentQuantity > 0)
                {
                    product.CurrentQuantity--;
                    await _context.SaveChangesAsync();

                    _context.Solds.Add(sold);
                    await _context.SaveChangesAsync();
                    return sold;
                }                
            }
         return null;
        }

        public async Task UpdateAsync(int soldId, Solds soldModel)
        {
            var sold = await _context.Solds.FindAsync(soldId);
            if (sold != null)
            {                
                sold.Name = soldModel.Name;
                sold.Price = soldModel.Price;                
                sold.PriceString = soldModel.PriceString;               
                sold.Tax = soldModel.Tax;
                sold.SellsDateTime = soldModel.SellsDateTime;

                await _context.SaveChangesAsync();
            }

        }

        public async Task DeleteAsync(int soldId)
        {           
            var sold = await GetByIdAsync(soldId);
            if (sold == null)
                throw new ItemNotFoundException($"{typeof(Solds).Name} with id {soldId} not found");
            _context.Solds.Remove(sold);

            await _context.SaveChangesAsync();
        }


    }
}
