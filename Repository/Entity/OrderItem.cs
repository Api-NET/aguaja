using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Entity
{
    [Table("tb_order_item")]
    public class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Stock_id { get; set; }
        public int Order_id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
