using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace foodme.server.Models
{
    public class MenuItem
    {
        [Key]
        public String name { get; set; }
        public String price { get; set; }
    }
}