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
    public class DiscountCardController : ControllerBase
    {
        private readonly IDiscountCardService _discountCardService;
        private readonly IMapper _mapper;
        private readonly ILogger<DiscountCardController> _logger;

        public DiscountCardController(IDiscountCardService discountCardService, IMapper mapper, ILogger<DiscountCardController> logger)
        {
            _discountCardService = discountCardService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<IEnumerable<DiscountCardDTO>> GetAllDiscountCards()
        {
            _logger.LogInformation("Getting maximum product sales");
            var discountcards = _mapper.Map<IEnumerable<DiscountCardDTO>>(await _discountCardService.GetAllAsync());
            return discountcards;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<DiscountCardDTO>>> GetDiscountCardById([FromRoute] int id)
        {
            _logger.LogInformation($"Getting discount card with id = {id}");
            var product = _mapper.Map<DiscountCardDTO>(await _discountCardService.GetByIdAsync(id));
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("")]
        public async Task<ActionResult> AddNewDiscountCard([FromBody] DiscountCardDTO discountCardDTO)
        {
            _logger.LogInformation("Adding new discount card");
            var discountCard = await _discountCardService.AddAsync(_mapper.Map<DiscountCard>(discountCardDTO));
            return CreatedAtAction(nameof(GetDiscountCardById), new { id = discountCard.Id}, _mapper.Map<DiscountCardDTO>(discountCard));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDiscountCard([FromBody] DiscountCardDTO discountCardDTO, [FromRoute] int id)
        {
            _logger.LogInformation($"update discount card with id {id}");
            if (id != discountCardDTO.Id) ModelState.AddModelError("id", "Your id != entity id");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _discountCardService.UpdateAsync(id, _mapper.Map<DiscountCard>(discountCardDTO));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscountCard([FromRoute] int id)
        {
            _logger.LogInformation($"Delete discount card with id = {id}");
            await _discountCardService.DeleteAsync(id);
            return Ok();
        }




    }
}
