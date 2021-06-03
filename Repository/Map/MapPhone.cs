using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Map
{
    public class MapPhone
    {
        public MapPhone(EntityTypeBuilder<Phone> etPhone)
        {
            etPhone.HasKey(Phone => Phone.Id);
        }
    }
}
