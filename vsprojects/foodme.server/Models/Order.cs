using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace foodme.server.Models
{
    public class Order
    {
        public String orderId { get; set; }
        public Restaurant restaurant { get; set; } 
        public List<MenuItem> items { get; set; }
        public Payment payment { get; set; }
        public Customer deliverTo { get; set; }
    }
}