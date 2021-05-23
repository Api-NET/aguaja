using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Map;

namespace Repository
{
    public class AppContextApi : DbContext
    {
        public AppContextApi(DbContextOptions<AppContextApi> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            new MapSeller(model.Entity<Seller>());
            new MapClient(model.Entity<Client>());
        }

    }
}
