using BeerAPI.Data.Interfaces;
using BeerAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly IBeerRepo _beerRepo;

        public BeerController(IBeerRepo _) => _beerRepo = _;

        // GET: api/<BeerController>
        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _beerRepo.GetBeers());

        // GET api/<BeerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _beerRepo.GetBeer(id);
            if (item is null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST api/<BeerController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Beer beer)
        {
            if (beer is null) return BadRequest();
            if (string.IsNullOrEmpty(beer.Name))
            {
                ModelState.AddModelError("Nombre", "El nombre de la cerveza podría estar vacía, verifíquelo.");
            }

            if (beer.IdTradeMark <= 0)
            {
                ModelState.AddModelError("Nombre", "Al parecer falta la marca de la cerveza, verifíquelo.");
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);
            var created = await _beerRepo.InsertBeer(beer);
            return Created("created", created);
        }

        // PUT api/<BeerController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Beer beer)
        {
            if (beer is null) return BadRequest();

            if (string.IsNullOrEmpty(beer.Name))
            {
                ModelState.AddModelError("Nombre", "El nombre de la cerveza podría estar vacía, verifíquelo.");
            }

            if (beer.IdTradeMark <= 0)
            {
                ModelState.AddModelError("Nombre", "Al parecer falta la marca de la cerveza, verifíquelo.");
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _beerRepo.UpdateBeer(beer);
            return NoContent();
        }

        // DELETE api/<BeerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest();
            await _beerRepo.DeleteBeer(id);
            return NoContent();
        }
    }
}
