using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hw_5.InterFace;
namespace Hw_5.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Barcode { get; set; }
        public override string ToString()
        {
            return ($"name = {Name} id = {ProductId} , barcode = {Barcode}");
        }
    }
}
