using Automat.Client.BlazorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Services.Interfaces
{
    public interface IBlazorProductsService
    {
        Task<IEnumerable<BlazorProductDTO>> GetProducts();
        Task<BlazorProductDTO> GetProductById(int productId);
        Task<bool> CreateProduct(BlazorProductDTO product);
        Task<bool> UpdateProduct(int productId, BlazorProductDTO product);
        Task<bool> DeleteProduct(int productId);
    }
}
