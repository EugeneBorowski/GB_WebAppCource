using System.Threading.Tasks;
using GB_WebAppCource.Controllers.Models;
using GB_WebAppCource.DAL.Entities;
using GB_WebAppCource.Services;
using GB_WebAppCource.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GB_WebAppCource.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IService<PersonDto> _service;

        public PersonsController(IService<PersonDto> service)
        {
            _service = service;
        }

        // GET: api/<PersonsController>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return Ok(await _service.Get(id));
        }

        // GET: api/<PersonsController>/all
        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAll());
        }

        // GET api/<PersonsController>/search?searchTerm={term}
        [HttpGet("searchTerm={term}")]
        public async Task<IActionResult> Get([FromRoute] string term)
        {
            return Ok(await _service.Get(term));
        }

        // GET api/<PersonsController>/?skip={from}&take={to}
        [HttpGet("skip={from}&take={to}")]
        public async Task<IActionResult> Get([FromRoute] int from, int to)
        {
            return Ok(await _service.Get(from,to));
        }

        // POST api/<PersonsController>
        [HttpPost("create")]
        public async Task<IActionResult> Post([FromBody] PersonDto person)
        {
            await _service.Create(person);
            return Ok();
        }

        // PUT api/<PersonsController>/5
        [HttpPut("update")]
        public async Task<IActionResult> Put([FromBody] PersonDto person)
        {
            await _service.Update(person);
            return Ok();
        }

        // DELETE api/<PersonsController>/5
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
