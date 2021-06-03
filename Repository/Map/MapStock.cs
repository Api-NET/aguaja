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
        }
    }
}
