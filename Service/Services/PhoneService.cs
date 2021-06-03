using Repository.Base;
using Repository.Entity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class PhoneService : IPhone
    {
        private readonly IRepositoryBase<Phone> _repositoryBase;

        public PhoneService(IRepositoryBase<Phone> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Delete(Phone phone)
        {
            _repositoryBase.Delete(phone);
        }

        public Phone Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Phone> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public void Insert(Phone phone)
        {
            _repositoryBase.Insert(phone);
        }

        public void Update(Phone phone)
        {
            _repositoryBase.Update(phone);
        }
    }
}
