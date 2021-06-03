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
    public class OrderController : ControllerBase
    {
        private readonly IOrder _orderInterface;

        public OrderController(IOrder order)
        {
            _orderInterface = order;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orderInterface.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Order order)
        {
            _orderInterface.Insert(order);
        }

        [HttpPut]
        public void Put([FromBody] Order order)
        {
            _orderInterface.Update(order);
        }

        [HttpDelete]
        public void Delete([FromBody] Order order)
        {
            _orderInterface.Delete(order);
        }
    }
}
