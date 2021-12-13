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

namespace AutomatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceManController : ControllerBase
    {
        private readonly IServiceManService _serviceManService;
        private readonly IMapper _mapper;
        private readonly ILogger<ServiceManController> _logger;

        public ServiceManController(IServiceManService serviceManService, IMapper mapper, ILogger<ServiceManController> logger)
        {
            _serviceManService = serviceManService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<IEnumerable<ServiceManDTO>> GetAllServiceMen()
        {
            _logger.LogInformation("Getting all service men");
            var servicemen = _mapper.Map<IEnumerable<ServiceManDTO>>(await _serviceManService.GetAllAsync());
            return servicemen;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ServiceManDTO>>> GetServiceManById([FromRoute] int id)
        {
            _logger.LogInformation($"Getting service man by id = {id}");
            var product = _mapper.Map<ServiceManDTO>(await _serviceManService.GetByIdAsync(id));
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("")]
        public async Task<ActionResult> AddNewServiceMan([FromBody] ServiceManDTO serviceManDTO)
        {
            _logger.LogInformation("Adding new service man");
            var serviceMan = await _serviceManService.AddAsync(_mapper.Map<ServiceMan>(serviceManDTO));
            return CreatedAtAction(nameof(GetServiceManById), new { id = serviceMan.Id}, _mapper.Map<ServiceManDTO>(serviceMan));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateServiceMan([FromBody] ServiceManDTO serviceManDTO, [FromRoute] int id)
        {
            _logger.LogInformation($"Updating service man by id = {id}");
            if (id != serviceManDTO.Id) ModelState.AddModelError("id", "Your id != entity id");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _serviceManService.UpdateAsync(id, _mapper.Map<ServiceMan>(serviceManDTO));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceMan([FromRoute] int id)
        {
            _logger.LogInformation($"Delete service man by id = {id}");
            await _serviceManService.DeleteAsync(id);
            return Ok();
        }



        [HttpPut("{productname}, {quantity}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] string productname, [FromRoute] int quantity)
        {
            _logger.LogInformation($"Update product with name = {productname}");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _serviceManService.AddProducts(productname, quantity);
            return Ok();
        }



    }
}
