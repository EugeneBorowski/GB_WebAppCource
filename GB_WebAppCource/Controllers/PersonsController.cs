using GB_WebAppCource.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GB_WebAppCource.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsService _service;

        public PersonsController(IPersonsService service)
        {
            _service = service;
        }

        // GET: api/<PersonsController>
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok();
        }

        // GET api/<PersonsController>/5
        [HttpGet("search?searchTerm={term}")]
        public string Get([FromRoute] string term)
        {
            return "value";
        }

        [HttpGet("?skip={from}&take={to}")]
        public IActionResult Get([FromRoute] int from, int to)
        {
            from = 5;
            to = 10;
            return Ok();
        }

        // POST api/<PersonsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonsController>/5
        [HttpPut]
        public void Put([FromBody] string value)
        {
        }

        // DELETE api/<PersonsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
