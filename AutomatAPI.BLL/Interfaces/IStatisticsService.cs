using System.Collections.Generic;
using System.Threading.Tasks;
using Automat.Models.Statistics;
using AutomatAPI.Models;

namespace Automat.BLL.Interfaces
{
    public interface IStatisticsService
    {
        Task<DrinkPercengate> GetMaxProductSell();
        Task<IEnumerable<Product>> GetTotalSellsByDescending();
        Task<string> GetProduct(string productname);       
        Task<IEnumerable<Solds>> GetTodaySells();
        Task<IEnumerable<Solds>> GetCurrentMonthSells();
        Task<IEnumerable<Solds>> GetCurrentYearSells();


    }
}
