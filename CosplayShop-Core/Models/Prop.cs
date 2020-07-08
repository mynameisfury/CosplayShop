using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosplayShop.Models
{
    public class Prop
    {
        [Key]
        public int ID { get; set; }
        public string PropName { get; set; }
        public Franchise FranchiseName { get; set; }
        public Character CharacterName { get; set; }
        public long Price { get; set; }


    }
}