using Hw_5.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5.InterFace
{
    public interface IProductRepository
    {
        string AddProduct(Product product);
        List<Product> GetProductList();
        string GetProductById(int id);




    }
}
