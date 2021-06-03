using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IOrderItem
    {
        OrderItem Get(int id);
        IEnumerable<OrderItem> GetAll();
        void Insert(OrderItem orderItem);
        void Update(OrderItem orderItem);
        void Delete(OrderItem orderItem);
    }
}
