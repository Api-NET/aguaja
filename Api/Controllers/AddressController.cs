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
    public class AddressController : ControllerBase
    {
        private readonly IAddress _addressInterface;

        public AddressController(IAddress address)
        {
            _addressInterface = address;
        }

        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return _addressInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Address Get(int id)
        {
            return _addressInterface.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Address address)
        {
            _addressInterface.Insert(address);
        }

        [HttpPut]
        public void Put([FromBody] Address address)
        {
            _addressInterface.Update(address);
        }

        [HttpDelete]
        public void Delete([FromBody] Address address)
        {
            _addressInterface.Delete(address);
        }
    }
}
