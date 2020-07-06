using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosplayShop.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public User User { get; set; }

        public long Subtotal { get; set; }
        
        public List<Prop> PropsInOrder { get; set; }



    }
}