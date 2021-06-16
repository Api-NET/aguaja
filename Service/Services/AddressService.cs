using Repository.Base;
using Repository.Entity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AddressService : IAddress
    {
        private readonly IRepositoryBase<Address> _repositoryBase;

        public AddressService(IRepositoryBase<Address> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Delete(Address address)
        {
            _repositoryBase.Delete(address);
        }

        public Address Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Address> GetAll()
        {
            return _repositoryBase.GetAll("");
        }

        public void Insert(Address address)
        {
            _repositoryBase.Insert(address);
        }

        public void Update(Address address)
        {
            _repositoryBase.Update(address);
        }
    }
}
