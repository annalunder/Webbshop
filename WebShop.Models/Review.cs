using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public int BookId { get; set; }
    }
}
