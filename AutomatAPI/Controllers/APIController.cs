using Automat.BLL.Services;
using Automat.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
		private readonly ServiceAPI _fruitApi;
		private readonly ILogger<APIController> _logger;
		public APIController(ServiceAPI fruitApi, ILogger<APIController> logger)
		{
			_fruitApi = fruitApi;
			_logger = logger;
		}

		[HttpGet("{product}")]

		public async Task<IEnumerable<Composition>> GetProductComposition(string product)
		{

			_logger.LogInformation("API Getting information about product");
			var fruit = await _fruitApi.GetProductComposition(product);
			if (fruit == null)
			{
				return null;
			}
			return fruit;
		}
		/*
		public async Task<IEnumerable<ProductDTO>> GetAllProducts()
		{
			_logger.LogInformation("Getting all products");
			var products = _mapper.Map<IEnumerable<ProductDTO>>(await _productService.GetAllAsync());
			return products;
		}*/
	}
}
