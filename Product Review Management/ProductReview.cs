﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    //getter and setter fields
    public class ProductReview
    {
        public int productId { get; set; }
        public int userId { get; set; }
        public int rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}

