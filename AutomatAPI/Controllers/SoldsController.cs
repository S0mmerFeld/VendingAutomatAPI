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
    public class SoldsController : ControllerBase
    {
        private readonly ISoldsService _soldsService;
        private readonly IMapper _mapper;
        private readonly ILogger<SoldsController> _logger;
        public SoldsController(ISoldsService soldsService, IMapper mapper, ILogger<SoldsController> logger)
        {
            _soldsService = soldsService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<IEnumerable<SoldsDTO>> GetAllSolds()
        {
            _logger.LogInformation("Getting all solds");
            var solds = _mapper.Map<IEnumerable<SoldsDTO>>(await _soldsService.GetAllAsync());
            return solds;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SoldsDTO>> GetSoldById([FromRoute] int id)
        {
            _logger.LogInformation($"Getting sold by id = {id}");
            var sold = _mapper.Map<SoldsDTO>(await _soldsService.GetByIdAsync(id));
            if (sold == null)
            {
                return NotFound();
            }
            return Ok(sold);
        }

        [HttpPost("")]
        public async Task<ActionResult> AddNewSold([FromBody] SoldsDTO soldDTO)
        {
            _logger.LogInformation("Adding new sold");
            var sold = await _soldsService.AddAsync(_mapper.Map<Solds>(soldDTO));
            return CreatedAtAction(nameof(GetSoldById), new { id = sold.Id }, _mapper.Map<SoldsDTO>(sold));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSold([FromBody] SoldsDTO soldsDTO, [FromRoute] int id)
        {
            _logger.LogInformation($"Update sold with id = {id}");
            if (id != soldsDTO.Id) ModelState.AddModelError("id", "Your id != entity id");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _soldsService.UpdateAsync(id, _mapper.Map<Solds>(soldsDTO));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            _logger.LogInformation($"Delete sold with id = {id}");
            await _soldsService.DeleteAsync(id);
            return Ok();
        }


    }
}
