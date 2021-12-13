using Automat.DAL.Context;
using Automat.DAL.Repositories;
using Automat.BLL.Interfaces;
using Automat.Models.Statistics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatAPI.Models;

namespace Automat.BLL.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ProductContext _productcontext;
        public StatisticsService(ProductContext productcontext)
        {
            _productcontext = productcontext;
        }


        public async Task<DrinkPercengate> GetMaxProductSell()
        {
            var products = await _productcontext.Product
                  .Select(g => new
                  {
                      Num = g.Id,
                      Amount = g.Sells
                  })
                  .ToListAsync();
            int productSum = products.Sum(g => g.Amount);
            int maxSells = products.Max(g => g.Amount);
            var result = products.OrderByDescending(g => g.Num).LastOrDefault();
            return new DrinkPercengate()
            {
                ProductNum = result.Num,
                Percentage = ((float)result.Amount / (float)maxSells) * 100.0f,
                TotalAmount = productSum,
                ProductAmount = result.Amount,
            };
        }

        public async Task<string> GetProduct(string productname)
        {
            var products = await _productcontext.Product
                   .Select(g => new
                   {
                       Name = g.Name,
                       Price = g.Price,
                       Sells = g.Sells,
                       Income = g.Price * g.Sells
                   })
                   .FirstOrDefaultAsync();
            return $"Product {products.Name} with price {products.Price} with sells {products.Sells} on sum {products.Income} were sold";
        }

        public async Task<IEnumerable<Product>> GetTotalSellsByDescending()
        {
             return await _productcontext.Product
                   .OrderByDescending(a => a.Sells)
                   .ToListAsync();            
        }

        public async Task<IEnumerable<Solds>> GetTodaySells()
        {
            var products = await _productcontext.Solds
                   .Where(o => o.SellsDateTime.Day == DateTime.Now.Day)
                   .ToListAsync();
            return products;
        }


        public async Task<IEnumerable<Solds>> GetCurrentMonthSells()
        {
            var products = await _productcontext.Solds
                   .Where(o => o.SellsDateTime.Month == DateTime.Now.Month)
                   .ToListAsync();
            return products;
        }


        public async Task<IEnumerable<Solds>> GetCurrentYearSells()
        {
            var products = await _productcontext.Solds
                   .Where(o => o.SellsDateTime.Year == DateTime.Now.Year)
                   .ToListAsync();
            return products;
        }
       
    }
}
