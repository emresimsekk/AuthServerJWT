﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServerJWT.Core.Dtos
{
    public class ProductDto
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public string UserID { get; set; }
    }
}
