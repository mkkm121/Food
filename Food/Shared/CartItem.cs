﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Food.Shared
{
    public class CartItem
    {
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public CustomerOrder Order { get; set; }
        public int OrderId { get; set; }
        public int EditionId { get; set; }
        public string ProductTitle { get; set; }
        public string EditionName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
    }
}
