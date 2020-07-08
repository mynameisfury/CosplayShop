using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosplayShop.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public DateTime Birthday { get; set; }
        public List<Prop> Wishlist { get; set; }
        


    }
}