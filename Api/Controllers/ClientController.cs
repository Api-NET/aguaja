using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Entity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MinhaPolitica")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClient _clientInterface;

        public ClientController(IClient client)
        {
            _clientInterface = client;
        }

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _clientInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Client Get(int id)
        {
            return _clientInterface.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Client client)
        {
            _clientInterface.Insert(client);
        }

        [HttpPost]
        public void Put([FromBody] Client client)
        {
            _clientInterface.Update(client);
        }

        [HttpDelete]
        public void Delete([FromBody] Client client)
        {
            _clientInterface.Delete(client);
        }
    }
}
