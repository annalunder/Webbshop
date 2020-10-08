using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public DateTime CreatedOn { get; set; }

        public bool NotificationSent { get; set; }
    }
}