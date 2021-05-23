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
    public class SellerController : ControllerBase
    {
        private readonly ISeller _sellerInterface;

        public SellerController(ISeller seller)
        {
            _sellerInterface = seller;
        }

        [HttpGet]
        public IEnumerable<Seller> Get()
        {
            return _sellerInterface.GetAll();
        }

        [HttpGet("{id}")]
        public Seller Get(int id)
        {
            return _sellerInterface.Get(id);
        }
    }
}
