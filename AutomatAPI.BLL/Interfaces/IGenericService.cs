using AutomatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.DAL.Repositories
{
    public interface IGenericService<T> where T : class
    {       
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T model);
        Task UpdateAsync(int id, T model);
        Task DeleteAsync(int id);
    }
}
