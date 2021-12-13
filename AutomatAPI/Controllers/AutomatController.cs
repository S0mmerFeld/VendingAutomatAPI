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
    public class AutomatController : ControllerBase
    {
        private readonly IAutomatMachineService _automatMachineService;
        private readonly IMapper _mapper;
        private readonly ILogger<AutomatController> _logger;

        public AutomatController(IAutomatMachineService automatMachineService, IMapper mapper, ILogger<AutomatController> logger)
        {
            _automatMachineService = automatMachineService;
            _mapper = mapper;
            _logger = logger;
        }
       
        [HttpGet("")]
        public async Task<IEnumerable<AutomatMachineDTO>> GetAllAutomatMachines()
        {
            _logger.LogInformation("Getting information about all machines");
            var automats = _mapper.Map<IEnumerable<AutomatMachineDTO>>(await _automatMachineService.GetAllAsync());
            return automats;
        }
      
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AutomatMachineDTO>>> GetAutomatMachineById([FromRoute] int id)
        {
            _logger.LogInformation("Getting information about automat by Id");
            var product = _mapper.Map<AutomatMachineDTO>(await _automatMachineService.GetByIdAsync(id));
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("")]
        public async Task<ActionResult> AddNewAutomatMachine([FromBody] AutomatMachineDTO automatMachineDTO)
        {
            _logger.LogInformation("Adding New Automat Machine");
            var automatMachine = await _automatMachineService.AddAsync(_mapper.Map<AutomatMachine>(automatMachineDTO));
            return CreatedAtAction(nameof(GetAutomatMachineById), new { id = automatMachine.Id }, _mapper.Map<AutomatMachineDTO>(automatMachine));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAutomatMachine([FromBody] AutomatMachineDTO automatMachineDTO, [FromRoute] int id)
        {
            _logger.LogInformation($"Updating information about Automat with {id}");
            if (id != automatMachineDTO.Id) ModelState.AddModelError("id", "Your id != entity id");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _automatMachineService.UpdateAsync(id, _mapper.Map<AutomatMachine>(automatMachineDTO));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutomatMachine([FromRoute] int id)
        {
            _logger.LogInformation($"Delete automat with {id}");
            await _automatMachineService.DeleteAsync(id);
            return Ok();
        }




    }
}
