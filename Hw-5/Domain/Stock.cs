using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5.Domain
{
    public class Stock
    {
        public int stockId { get; set; }
        public string name { get; set; }
        public int productId { get; set; }
        public int productQuantity { get; set; }
        public int productPrice { get; set; }

    }
}
