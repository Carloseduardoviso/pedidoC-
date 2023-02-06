using System;
using System.Collections.Generic;
using System.Globalization;

namespace projeto1.Entities
{
    internal class OrdeItem
    {
        public int Quatity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrdeItem()
        {

        }

        public OrdeItem(int quatity, double price, Product produto)
        {
            Quatity = quatity;
            Price = price;
            Product = produto;
        }

        public double SubTotal()
        {
            return Price * Quatity;
        }

        public override string ToString()
        {
            return Product.Name
              + ", $"
              + Price.ToString("F2", CultureInfo.InvariantCulture)
              + ", Quantity: "
              + Quatity
              + ", Subtotal: $"
              + SubTotal().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
