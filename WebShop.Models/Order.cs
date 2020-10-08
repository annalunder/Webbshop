using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }

        public bool SentForShipment { get; set; }

        public enum OrderStatus
        {
            Unshipped,
            Pending,
            Complete,
            Cancelled
        };
    }
}
