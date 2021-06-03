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
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItem _orderItemInterface;

        public OrderItemController(IOrderItem orderItem)
        {
            _orderItemInterface = orderItem;
        }

        [HttpGet]
        public IEnumerable<OrderItem> Get()
        {
            return _orderItemInterface.GetAll();
        }

        [HttpGet("{id}")]
        public OrderItem Get(int id)
        {
            return _orderItemInterface.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] OrderItem orderItem)
        {
            _orderItemInterface.Insert(orderItem);
        }

        [HttpPut]
        public void Put([FromBody] OrderItem orderItem)
        {
            _orderItemInterface.Update(orderItem);
        }

        [HttpDelete]
        public void Delete([FromBody] OrderItem orderItem)
        {
            _orderItemInterface.Delete(orderItem);
        }
    }
}
