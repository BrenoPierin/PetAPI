using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPet.Domains;
using APIPet.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPetController : ControllerBase
    {
        TipoPetRepository repo = new TipoPetRepository();

        // GET: api/<TipoPetController>
        [HttpGet]
        public List<TipoPet> Get()
        {
            return repo.ListarTodos();
        }

        // GET api/<TipoPetController>/5
        [HttpGet("{id}")]
        public TipoPet Get(int id)
        {
            return repo.BuscarPorID(id);
        }

        // POST api/<TipoPetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TipoPetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoPetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
