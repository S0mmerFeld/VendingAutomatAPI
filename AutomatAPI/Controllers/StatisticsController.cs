using AutoMapper;
using Automat.BLL.Interfaces;
using Automat.Models.Statistics;
using AutomatAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automat.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _statisticsService;
        private readonly IMapper _mapper;
        private readonly ILogger<StatisticsController> _logger;

        public StatisticsController(IStatisticsService statisticsService, IMapper mapper, ILogger<StatisticsController> logger)
        {
            _statisticsService = statisticsService;
            _mapper = mapper;
            _logger = logger;
        }

        // product with max sells
        [HttpGet ("GetMaxProductSell")]        
        public async Task<ActionResult<DrinkPercengate>> GetMaxProductSell()
        {
            _logger.LogInformation("Getting maximum product sales");
            return await _statisticsService.GetMaxProductSell();
        }
        // products by total sells descending
        [HttpGet("GetTotalProductSell")]
        public async Task<IEnumerable<Product>> GetTotalSells()
        {
            _logger.LogInformation("Getting total product sales");
            return await _statisticsService.GetTotalSellsByDescending();
        }
        // get product sells with set name
        [HttpGet("GetProductSell")]
        public async Task<string> GetTotalSells([FromRoute] string name)
        {
            _logger.LogInformation("Getting total sales");
            return await _statisticsService.GetProduct(name);
        }




        // Get today products sells
        [HttpGet("GetTodayProductSell")]
        public async Task<IEnumerable<Solds>> GetTodaySells()
        {
            _logger.LogInformation("Getting today sales");
            return await _statisticsService.GetTodaySells();
        }
        // Get current month products sells
        [HttpGet("GetCurrentMonthProductSell")]
        public async Task<IEnumerable<Solds>> GetCurrentMonthSells()
        {
            _logger.LogInformation("Getting current month sales");
            return await _statisticsService.GetCurrentMonthSells();
        }
        // Get today products sells
        [HttpGet("GetCurrentYearProductSell")]
        public async Task<IEnumerable<Solds>> GetCurrentYearSells()
        {
            _logger.LogInformation("Getting current year sales");
            return await _statisticsService.GetCurrentYearSells();
        }

        

    }
}
