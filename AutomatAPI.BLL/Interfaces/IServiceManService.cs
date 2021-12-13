using AutomatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.DAL.Repositories
{
    public interface IServiceManService : IGenericService<ServiceMan>
    {
        Task AddProducts(string productname, int quantity);
    }
}
