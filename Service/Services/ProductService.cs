using Repository.Base;
using Repository.Entity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ProductService : IProduct
    {
        private readonly IRepositoryBase<Product> _repositoryBase;

        public ProductService(IRepositoryBase<Product> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Delete(Product product)
        {
            _repositoryBase.Delete(product);
        }

        public Product Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _repositoryBase.GetAll("Stocks");
        }

        public void Insert(Product product)
        {
            _repositoryBase.Insert(product);
        }

        public void Update(Product product)
        {
            _repositoryBase.Update(product);
        }
    }
}
