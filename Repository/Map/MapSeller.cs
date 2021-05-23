using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;

namespace Repository.Map
{
    class MapSeller
    {
        public MapSeller(EntityTypeBuilder<Seller> etSeller)
        {
            etSeller.HasKey(Pessoa => Pessoa.Id);
        }
    }
}
