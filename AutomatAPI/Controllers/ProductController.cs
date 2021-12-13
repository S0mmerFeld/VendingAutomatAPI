using AutoMapper;
using Automat.DAL.Repositories;
using AutomatAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace AutomatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductController> _logger;
        public ProductController(IProductService productService, IMapper mapper, ILogger<ProductController> logger)
        {
            _productService = productService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            _logger.LogInformation("Getting all products");
            var products = _mapper.Map<IEnumerable<ProductDTO>>(await _productService.GetAllAsync());
            return products;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProductById([FromRoute] int id)
        {
            _logger.LogInformation($"Getting product by id = {id}");
            var product = _mapper.Map<ProductDTO>(await _productService.GetByIdAsync(id));
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("")]
        public async Task<ActionResult> AddNewProduct([FromBody] ProductDTO productDTO)
        {
            _logger.LogInformation("Adding new product");
            var product = await _productService.AddAsync(_mapper.Map<Product>(productDTO));
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, _mapper.Map<ProductDTO>(product));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDTO productDTO, [FromRoute] int id)
        {
            _logger.LogInformation($"Update product with id = {id}");
            if (id != productDTO.Id) ModelState.AddModelError("id", "Your id != entity id");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _productService.UpdateAsync(id, _mapper.Map<Product>(productDTO));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            _logger.LogInformation($"Delete product with id = {id}");
            await _productService.DeleteAsync(id);
            return Ok();
        }


    }
}
