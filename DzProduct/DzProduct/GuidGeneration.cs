using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzProduct
{
    abstract public class GuidGeneration
    {
        public Guid Id { set; get; }

        public GuidGeneration()
        {
            Id = Guid.NewGuid();
        }
    }
}
