using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperDataAccessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketDetailsSPController : ControllerBase
    {

        private readonly ITicketSP Details;

        public TicketDetailsSPController()
        {
            Details = new TicketBookingSP();
        }

        // GET: api/<ProductsSPController>
        [HttpGet]
        public IEnumerable<TicketModelSP> Get()
        {
            return Details.ReadSP();
        }


        // GET api/<ProductsSPController>/5
        [HttpGet("{id}")]
        public List<TicketModelSP> Get(int id)
        {
            return Details.ReadbyIDSP(id);
        }

        // POST api/<ProductsSPController>
        [HttpPost]
        public void Post([FromBody] TicketModelSP value)
        {
            Details.InsertSP(value);
        }

        // PUT api/<ProductsSPController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TicketModelSP value)
        {
            Details.UpdateSP(id, value);
        }

        // DELETE api/<ProductsSPController>/5
        [HttpDelete("{id}")]
        public void DeleteSP(int id)
        {
            Details.DeleteSP(id);
        }
    }
}
