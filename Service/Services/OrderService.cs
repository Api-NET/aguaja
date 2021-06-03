using Repository.Base;
using Repository.Entity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class OrderService : IOrder
    {
        private readonly IRepositoryBase<Order> _repositoryBase;

        public OrderService(IRepositoryBase<Order> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Delete(Order order)
        {
            _repositoryBase.Delete(order);
        }

        public Order Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public void Insert(Order order)
        {
            _repositoryBase.Insert(order);
        }

        public void Update(Order order)
        {
            _repositoryBase.Update(order);
        }
    }
}
