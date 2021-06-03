using System;
using System.Collections.Generic;
using System.Text;
using Repository.Entity;

namespace Service.Interfaces
{
    public interface IOrder
    {
        Order Get(int id);
        IEnumerable<Order> GetAll();
        void Insert(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
