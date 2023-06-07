using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5.InterFace
{
    public interface IStockRepository
    {
        string SaleProduct(int  productId , int count);
    }
}
