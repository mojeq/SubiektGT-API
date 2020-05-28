using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubiektGT_API.Models
{
    public class Product
    {
        public int IdSubiekt { get; set; }
        public int Stock { get; set; }
        public string ProductSymbol { get; set; }
        public int IdGroupSubiekt { get; set; }
    }
}
