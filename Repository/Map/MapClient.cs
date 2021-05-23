using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Map
{
    public class MapClient
    {
        public MapClient(EntityTypeBuilder<Client> etClient)
        {
            etClient.HasKey(Client => Client.Id);
        }
    }
}
