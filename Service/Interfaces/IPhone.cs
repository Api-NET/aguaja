using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IPhone
    {
        Phone Get(int id);
        IEnumerable<Phone> GetAll();
        void Insert(Phone phone);
        void Update(Phone phone);
        void Delete(Phone phone);
    }
}
