using Microsoft.EntityFrameworkCore;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        private DbSet<TEntity> _entities;
        private readonly AppContextApi _context;

        public RepositoryBase(AppContextApi context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public void Delete(TEntity entidade)
        {
            _entities.Remove(entidade);
            _context.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = _entities;
            return query.ToList();
        }

        public void Insert(TEntity entidade)
        {
            _entities.Add(entidade);
            _context.SaveChanges();
        }

        public void Update(TEntity entidade)
        {
            _entities.Update(entidade);
            _context.SaveChanges();
        }
    }
}
