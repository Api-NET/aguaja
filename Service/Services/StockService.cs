using Repository.Base;
using Repository.Entity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class StockService : IStock
    {
        private readonly IRepositoryBase<Stock> _repositoryBase;

        public StockService(IRepositoryBase<Stock> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Delete(Stock stock)
        {
            _repositoryBase.Delete(stock);
        }

        public Stock Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Stock> GetAll()
        {
            return _repositoryBase.GetAll("Product");
        }

        public void Insert(Stock stock)
        {
            _repositoryBase.Insert(stock);
        }

        public void Update(Stock stock)
        {
            _repositoryBase.Update(stock);
        }
    }
}
