﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosplayShop.Models
{
    public class Franchise
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Character Character { get; set; }
        public Prop Prop { get; set; }
    }
}