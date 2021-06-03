using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IStock
    {
        Stock Get(int id);
        IEnumerable<Stock> GetAll();
        void Insert(Stock product);
        void Update(Stock product);
        void Delete(Stock product);
    }
}
