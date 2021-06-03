using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IProduct
    {
        Product Get(int id);
        IEnumerable<Product> GetAll();
        void Insert(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
