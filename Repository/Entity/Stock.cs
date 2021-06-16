using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Repository.Entity
{
    [Table("tb_stock")]
    public class Stock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public double Cost_price { get; set; }
        public double Cost_sell { get; set; }
        public DateTime Entry_date { get; set; }
        public int Quantity { get; set; } 
        public int Product_id { get; set; }
        public int Seller_id { get; set; }
        
        public Product Product { get; set; }

    }
}
