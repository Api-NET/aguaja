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
            new MapProduct(model.Entity<Product>());
            new MapStock(model.Entity<Stock>());
            new MapOrder(model.Entity<Order>());
            new MapOrderItem(model.Entity<OrderItem>());
            new MapAddress(model.Entity<Address>());
            new MapPhone(model.Entity<Phone>());
        }

    }
}
