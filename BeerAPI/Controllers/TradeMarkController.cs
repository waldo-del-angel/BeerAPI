using BeerAPI.Data.Interfaces;
using BeerAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BeerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeMarkController : ControllerBase
    {
        private readonly ITradeMarkRepo _tradeMarkRepo;

        public TradeMarkController(ITradeMarkRepo _) => _tradeMarkRepo = _;

        // GET: api/<TradeMarkController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _tradeMarkRepo.GetTradeMarks());
        }

        // GET api/<TradeMarkController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var tradeMark = await _tradeMarkRepo.GetTradeMark(id);
            if (tradeMark is null)
            {
                return NotFound();
            }
            return Ok(tradeMark);
        }

        // POST api/<TradeMarkController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TradeMark tradeMark)
        {
            if (tradeMark is null) return BadRequest();
            if (string.IsNullOrEmpty(tradeMark.Name))
            {
                ModelState.AddModelError("Nombre", "El nombre de la marca podría estar vacío, verifíquelo.");
            }
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var created = await _tradeMarkRepo.InsertTradeMark(tradeMark);
            return Created("created", created);
        }

        // PUT api/<TradeMarkController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TradeMark tradeMark)
        {
            if (tradeMark is null) return BadRequest();
            if (string.IsNullOrEmpty(tradeMark.Name))
            {
                ModelState.AddModelError("Nombre", "El nombre de la marca podría estar vacío, verifíquelo.");
            }
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _tradeMarkRepo.UpdateTradeMark(tradeMark);
            return NoContent();
        }

        // DELETE api/<TradeMarkController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest();
            await _tradeMarkRepo.DeleteTradeMark(id);
            return NoContent();
        }
    }
}
