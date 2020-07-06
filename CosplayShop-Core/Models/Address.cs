using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosplayShop.Models
{
    public class Address
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public City City { get; set; }
        public State State { get; set; }
        public ZipCode ZipCode { get; set; }

    }
}