using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWeb.Models
{
    public class CompoundInterest
    {
        public CompoundInterest() { }
        public double P { get; set; }
        public double R { get; set; }
        public int N { get; set; }
        public int T { get; set; }
        public double Result { get; set; }
    }
}
