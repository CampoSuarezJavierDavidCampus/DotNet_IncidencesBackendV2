using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiIncidences.Controllers
{
    public class CountryController: BaseApiController
    {
        
        private readonly IUnitOfWork _UnitOfWork;
        public CountryController(IUnitOfWork unitOfWork) => _UnitOfWork = unitOfWork;

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Country>>> Get(){
            var regions = await _UnitOfWork.Countries.GetAllAsync();
            return Ok(regions);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id ){
            var regions = await _UnitOfWork.Countries.GetByIdAsync(id);
            return Ok(regions);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Country>> Post(Country country){
            _UnitOfWork.Countries.Add(country);
            if(country is null){
                return BadRequest();
            }
            await _UnitOfWork.SaveAsync();
            return CreatedAtAction(nameof(Post), new {id = country.IdCountry}, country);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Country>> Put(int id, [FromBody]Country country){
            var oldCountry = await _UnitOfWork.Countries.GetByIdAsync(id);
            if (oldCountry is null)
            {
                return NotFound();
            }

            if (country is null )
            {
                return BadRequest();
            }

            _UnitOfWork.Countries.Update(country);
            await _UnitOfWork.SaveAsync();
            return country;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id){
            var country = await _UnitOfWork.Countries.GetByIdAsync(id);
            if (country is null)
            {
                return NotFound();
            }

            _UnitOfWork.Countries.Remove(country);
            await _UnitOfWork.SaveAsync();
            return NoContent();

        }
    }
}