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
    public class PhoneController : ControllerBase
    {
        private readonly IPhone _phoneInterface;

        public PhoneController(IPhone phone)
        {
            _phoneInterface = phone;
        }

        [HttpGet]
        public IEnumerable<Phone> Get()
        {
            return _phoneInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Phone Get(int id)
        {
            return _phoneInterface.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Phone phone)
        {
            _phoneInterface.Insert(phone);
        }

        [HttpPut]
        public void Put([FromBody] Phone phone)
        {
            _phoneInterface.Update(phone);
        }

        [HttpDelete]
        public void Delete([FromBody] Phone phone)
        {
            _phoneInterface.Delete(phone);
        }
    }
}
