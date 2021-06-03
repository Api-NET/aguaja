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
        }
    }
}
