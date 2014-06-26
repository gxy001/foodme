using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace foodme.server.Models
{
    public class Restaurant
    {
        public String id { get; set; }
        public String name { get; set; }
        public String cuisine { get; set; }
        public String opens { get; set; }
        public String closes { get; set; }
        public List<int> days { get; set;}
        public int price { get; set; }
        public int rating { get; set; }
        public String location { get; set; }
        public String description { get; set; }
        public List<MenuItem> menuItems { get; set; }
    }
}