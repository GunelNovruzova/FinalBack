﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class ProductTag
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> TagId { get; set; }
        public Product Product { get; set; }
        public Tag Tag { get; set; }
    }
}
