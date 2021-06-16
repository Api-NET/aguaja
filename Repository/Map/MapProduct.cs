using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Map
{
    public class MapProduct
    {
        public MapProduct(EntityTypeBuilder<Product> etProduct)
        {
            etProduct.HasKey(Product => Product.Id);
            etProduct.HasMany(st => st.Stocks).WithOne(en => en.Product).HasForeignKey(en => en.Product_id);

            etProduct.Navigation(en => en.Stocks).UsePropertyAccessMode(PropertyAccessMode.Property);
        }
    }
}
