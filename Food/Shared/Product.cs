﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = "https://via.palceholder.com/300x300";

        public decimal Price { get; set; }

        public decimal OriginalPrice { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }

        public Category Category { get; set; }

        public int CategoryID { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime DateUpdated { get; set; }


    }
}