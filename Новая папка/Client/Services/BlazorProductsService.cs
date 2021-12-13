using Blazor.Client.BlazorDTOs;
using Blazor.Client.Clients.Interfaces;
using Blazor.Client.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Client.Services
{
    public class BlazorProductsService : IBlazorProductsService
    {
        private readonly IProductClient _iProductsClient;
        public BlazorProductsService(IProductClient iProductClient)
        {
            _iProductsClient = iProductClient;
        }

        public async Task<IEnumerable<BlazorProductDTO>> GetProducts()
        {
            return await _iProductsClient.GetAllItems();
        }

        public async Task<BlazorProductDTO> GetProductById(int id)
        {
            return await _iProductsClient.GetById(id);
        }

        public async Task<bool> CreateProduct(BlazorProductDTO product)
        {
            return await _iProductsClient.Create(product);
        }

        public async Task<bool> DeleteProduct(int productid)
        {
            return await _iProductsClient.Delete(productid);
        }

        public async Task<bool> UpdateProduct(int productid, BlazorProductDTO product)
        {
            return await _iProductsClient.Update(productid, product);
        }

        
    }
}
