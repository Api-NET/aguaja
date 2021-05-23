using System;
using System.Collections.Generic;
using System.Text;
using Repository.Entity;

namespace Service.Interfaces
{
    public interface ISeller
    {
        Seller Get(int id);
        IEnumerable<Seller> GetAll();
        void Insert(Seller seller);
        void Update(Seller seller);
        void Delete(Seller seller);
    }
}
