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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string StreetAddress { get; set; }
        public City City { get; set; }
        public State State { get; set; }
        public ZipCode ZipCode { get; set; }



    }
}