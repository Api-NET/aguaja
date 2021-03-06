using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity
{
    [Table("tb_seller")]
    public class Seller
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Admin { get; set; }
        public DateTime Birth_date { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public int Address_id { get; set; }
        public int Phone_id { get; set; }


    }
}
