using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IClient
    {
        Client Get(int id);
        IEnumerable<Client> GetAll();
        void Insert(Client client);
        void Update(Client client);
        void Delete(Client client);
    }
}
