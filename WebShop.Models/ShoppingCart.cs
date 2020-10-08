using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Models
{
    public class ShoppingCart
    {
        ICollection<Item> Items { get; set; }

        public string AddItem()
        {
            return Items.ToString();
        }
    }
}