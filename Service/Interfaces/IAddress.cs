using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IAddress
    {
        Address Get(int id);
        IEnumerable<Address> GetAll();
        void Insert(Address address);
        void Update(Address address);
        void Delete(Address address);
    }
}
