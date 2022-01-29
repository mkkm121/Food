﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Food.Shared
{
    public class OrderDetail
    {
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public CustomerOrder Order { get; set; }

        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
    }
}
