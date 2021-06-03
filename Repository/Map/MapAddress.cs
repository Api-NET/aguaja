using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Map
{
    public class MapAddress
    {
        public MapAddress(EntityTypeBuilder<Address> etAddress)
        {
            etAddress.HasKey(Address => Address.Id);
        }
    }
}
