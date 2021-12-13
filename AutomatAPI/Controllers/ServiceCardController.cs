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
    public class ServiceCardController : ControllerBase
    {
        private readonly IServiceCardService _serviceCardService;
        private readonly IMapper _mapper;
        private readonly ILogger<ServiceCardController> _logger;

        public ServiceCardController(IServiceCardService serviceCardService, IMapper mapper, ILogger<ServiceCardController> logger)
        {
            _serviceCardService = serviceCardService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<IEnumerable<ServiceCardDTO>> GetAllServiceCards()
        {
            _logger.LogInformation("Getting all service cards");
            var servicecards = _mapper.Map<IEnumerable<ServiceCardDTO>>(await _serviceCardService.GetAllAsync());
            return servicecards;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ServiceCardDTO>>> GetServiceCardById([FromRoute] int id)
        {
            _logger.LogInformation($"Getting service card by id = {id}");
            var product = _mapper.Map<ServiceCardDTO>(await _serviceCardService.GetByIdAsync(id));
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("")]
        public async Task<ActionResult> AddNewServiceCard([FromBody] ServiceCardDTO serviceCardDTO)
        {
            _logger.LogInformation("Adding new service card");
            var serviceCard = await _serviceCardService.AddAsync(_mapper.Map<ServiceCard>(serviceCardDTO));
            return CreatedAtAction(nameof(GetServiceCardById), new { id = serviceCard.Id}, _mapper.Map<ServiceCardDTO>(serviceCard));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateServiceCard([FromBody] ServiceCardDTO serviceCardDTO, [FromRoute] int id)
        {
            _logger.LogInformation($"Update service card with id = {id}");
            if (id != serviceCardDTO.Id) ModelState.AddModelError("id", "Your id != entity id");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _serviceCardService.UpdateAsync(id, _mapper.Map<ServiceCard>(serviceCardDTO));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceCard([FromRoute] int id)
        {
            _logger.LogInformation($"Delete service card with id = {id}");
            await _serviceCardService.DeleteAsync(id);
            return Ok();
        }




    }
}
