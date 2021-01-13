using System;

namespace AuthServerJWT.Core.Entity
{
    public class Product
    {
        public int id{ get; set; }
        public string Name{ get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public string UserID { get; set; }
    }
}
