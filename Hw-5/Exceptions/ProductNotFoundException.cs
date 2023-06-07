using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string massage) :base(massage) { }
       
    }
}
