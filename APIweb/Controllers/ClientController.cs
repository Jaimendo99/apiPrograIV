using APIweb.Models;
using Microsoft.AspNetCore.Mvc;
using APIweb.Utils;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIweb.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {           
       
        // GET: api/<ClientController>
        [HttpGet]
        public IActionResult Get()
        {
            

            return Ok(Utils.Utils.clients);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Client client = Utils.Utils.clients.Find(x => x.id == id);

            return Ok(client);
        }

        // POST api/<ClientController>
        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            Client client2 = Utils.Utils.clients.Find(x => x.id == client.id);


            if (client2 == null)
            {
                Client client1 = new Client()
                {
                    id = client.id,
                    name = client.name,
                    email = client.email,
                    phoneNumber = client.phoneNumber,
                };
                Utils.Utils.clients.Add(client1);
                return Ok();
            }
            else
            {
                return BadRequest();
            }





        }
        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
