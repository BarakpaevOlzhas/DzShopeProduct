using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzProduct
{
    public class Product : GuidGeneration
    {
        public string Name { set; get; }
        public int Price { set; get; }
        public Category IdCategory { set; get; }
    }
}
