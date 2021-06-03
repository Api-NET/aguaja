using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Map
{
    public class MapOrder
    {
        public MapOrder(EntityTypeBuilder<Order> etOrder)
        {
            etOrder.HasKey(Order => Order.Id);
        }
    }
}
