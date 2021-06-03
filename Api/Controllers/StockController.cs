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
    public class StockController : ControllerBase
    {
        private readonly IStock _stockInterface;

        public StockController(IStock stock)
        {
            _stockInterface = stock;
        }

        [HttpGet]
        public IEnumerable<Stock> Get()
        {
            return _stockInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Stock Get(int id)
        {
            return _stockInterface.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Stock stock)
        {
            _stockInterface.Insert(stock);
        }

        [HttpPut]
        public void Put([FromBody] Stock stock)
        {
            _stockInterface.Update(stock);
        }

        [HttpDelete]
        public void Delete([FromBody] Stock stock)
        {
            _stockInterface.Delete(stock);
        }
    }
}
