using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Models
{
    public class Item
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        // Name, Category?

        public int UpdateQuantity()
        {
            return 1;
        }
    }
}
