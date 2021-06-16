using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Repository.Entity
{
    [Table("tb_product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Description { get; set; }
        public string Url_image { get; set; }
        public string Name { get; set; }
        public double Liters { get; set; }
        [JsonIgnore]
        public IList<Stock> Stocks { get; set; }
    }
}
