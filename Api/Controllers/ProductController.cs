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
    public class ProductController : ControllerBase
    {
        private readonly IProduct _productInterface;

        public ProductController(IProduct product)
        {
            _productInterface = product;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productInterface.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _productInterface.Insert(product);
        }

        [HttpPut]
        public void Put([FromBody] Product product)
        {
            _productInterface.Update(product);
        }

        [HttpDelete]
        public void Delete([FromBody] Product product)
        {
            _productInterface.Delete(product);
        }
    }
}
