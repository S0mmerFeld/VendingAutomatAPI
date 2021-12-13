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
    public class ProductService : IGenericService<Product>, IProductService
    {
        private readonly ProductContext _context;
        public ProductService(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            var records = await _context.Product.Select(x => new Product()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Location = x.Location,
                Sells = x.Sells,
                Description = x.Description,
                PriceString = x.PriceString,              
                ShortDescription=x.ShortDescription ,               
                CurrentQuantity = x.CurrentQuantity
            }).ToListAsync();

            if (records == null)
                throw new ItemNotFoundException($"{typeof(Product).Name} could not found.");

            return records;
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            var records = await _context.Product.Where(x => x.Id == productId).Select(x => new Product()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Location = x.Location,
                Description = x.Description,
                Sells = x.Sells,
                PriceString = x.PriceString,
                ShortDescription = x.ShortDescription,
                CurrentQuantity = x.CurrentQuantity


            }).FirstOrDefaultAsync();

            if (records == null)
                throw new ItemNotFoundException($"{typeof(Product).Name} item with id {productId} not found.");

            return records;
        }

        public async Task<Product> AddAsync(Product productModel)
        {
            var product = new Product()
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Price = productModel.Price,
                Location = productModel.Location,                
                Sells = productModel.Sells,               
                ShortDescription = productModel.ShortDescription,
                PriceString = "Hrivnja",
                Description = "New Produ",
                CurrentQuantity = productModel.CurrentQuantity
            };

            _context.Product.Add(product);

            await _context.SaveChangesAsync();

            return product;

        }

        public async Task UpdateAsync(int productId, Product productModel)
        {
            var product = await _context.Product.FindAsync(productId);
            if (product != null)
            {
                product.Location = productModel.Location;
                product.Name = productModel.Name;
                product.Price = productModel.Price;              
                product.Sells = productModel.Sells;
               // product.PriceString = productModel.PriceString;
                product.ShortDescription = productModel.ShortDescription;
                product.CurrentQuantity = productModel.CurrentQuantity;


                await _context.SaveChangesAsync();
            }

        }

        public async Task DeleteAsync(int productId)
        {           
            var product = await GetByIdAsync(productId);
            if (product == null)
                throw new ItemNotFoundException($"{typeof(Product).Name} with id {productId} not found");
            _context.Product.Remove(product);

            await _context.SaveChangesAsync();
        }


    }
}
