using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosplayShop.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Prop Prop { get; set; }
        public List<Tag> Tags { get; set; }
    }
}