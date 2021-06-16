using Repository.Base;
using Repository.Entity;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ClientService : IClient
    {
        private readonly IRepositoryBase<Client> _repositoryBase;

        public ClientService(IRepositoryBase<Client> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public void Delete(Client client)
        {
            _repositoryBase.Delete(client);
        }

        public Client Get(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _repositoryBase.GetAll("");
        }

        public void Insert(Client client)
        {
            _repositoryBase.Insert(client);
        }

        public void Update(Client client)
        {
            _repositoryBase.Update(client);
        }
    }
}
