using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Entity
{
    [Table("tb_order")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Discount { get; set; }
        public int Order_status { get; set; }
        public int Client_id { get; set; }
        public int Seller_id { get; set; }
    }
}
