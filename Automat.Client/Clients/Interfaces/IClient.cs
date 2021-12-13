using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.Client.Clients.Interfaces
{
    public interface IClient<T> where T : class
    {
        Task<IEnumerable<T>> GetAllItems();
        Task<T> GetById(int id);
        Task<bool> Create(T entity);
        Task<bool> Update(int entityId, T entity);
        Task<bool> Delete(int id);

        Task<IEnumerable<T>> GetCompositionByProduct(string name);
    }
}
