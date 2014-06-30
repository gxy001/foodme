using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace foodme.server.Models
{
    public class Payment
    {
        public String type { get; set; }
        public String number { get; set; }
        public String expire { get; set; }
        public String cvc { get; set; }
    }
}
