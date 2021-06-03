using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Map
{
    public class MapOrderItem
    {
        public MapOrderItem(EntityTypeBuilder<Entity.OrderItem> etOrderItem)
        {
            etOrderItem.HasKey(OrderItem => OrderItem.Id);
        }
    }
}
