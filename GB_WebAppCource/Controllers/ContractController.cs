﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GB_WebAppCource.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        // GET: api/<InvoiceController>
        [HttpGet("/getall")]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // GET api/<InvoiceController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok();
        }

        // POST api/<InvoiceController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok();
        }

        // PUT api/<InvoiceController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE api/<InvoiceController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok();
        }
    }
}