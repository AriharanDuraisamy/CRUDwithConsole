using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIHari
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketDetailsSPController : ControllerBase
    {
        // GET: api/<TicketDetailsSPController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TicketDetailsSPController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TicketDetailsSPController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TicketDetailsSPController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TicketDetailsSPController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
