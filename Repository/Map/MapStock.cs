using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Map
{
    public class MapStock
    {
        public MapStock(EntityTypeBuilder<Stock> etStock)
        {
            etStock.HasKey(Stock => Stock.Id);

            etStock.HasOne(en => en.Product)
                .WithMany(e => e.Stocks)
                .HasForeignKey(en => en.Product_id);

            etStock.Navigation(en => en.Product)
                .UsePropertyAccessMode(PropertyAccessMode.Property);
        }
    }
}
