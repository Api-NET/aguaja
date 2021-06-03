using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Entity
{
    [Table("tb_address")]
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string Username { get; set; }
        public int Address_id { get; set; }
        public int Phone_id { get; set; }
    }
}
