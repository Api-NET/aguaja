using Repository.Entity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Base;

namespace Service.Services
{
    public class SellerService : ISeller
    {
        private readonly IRepositoryBase<Seller> _repositoryBase;

        public SellerService(IRepositoryBase<Seller> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Delete(Seller seller)
        {
            _repositoryBase.Delete(seller);
        }

        public Seller Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Seller> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public void Insert(Seller seller)
        {
            _repositoryBase.Insert(seller);
        }

        public void Update(Seller seller)
        {
            _repositoryBase.Update(seller);
        }
    }
}
