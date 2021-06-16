using Repository.Base;
using Repository.Entity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class OrderItemService : IOrderItem
    {
        private readonly IRepositoryBase<OrderItem> _repositoryBase;

        public OrderItemService(IRepositoryBase<OrderItem> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Delete(OrderItem orderItem)
        {
            _repositoryBase.Delete(orderItem);
        }

        public OrderItem Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<OrderItem> GetAll()
        {
            return _repositoryBase.GetAll("");
        }

        public void Insert(OrderItem orderItem)
        {
            _repositoryBase.Insert(orderItem);
        }

        public void Update(OrderItem orderItem)
        {
            _repositoryBase.Update(orderItem);
        }

    }
}
