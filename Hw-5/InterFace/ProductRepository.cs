using Hw_5.Domain;
using Hw_5.Exceptions;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Hw_5.InterFace
{
    public class ProductRepository : IProductRepository
    {
        public string stream;

          List<Product> products = new List<Product>()
        {
            new Product(1,"Miio_123", 123),
        };
        string path = @"ProductJson.json";
        public string AddProduct(Product product)
        {
            products = GetProductList();
            var searchproduct = products.Find(p =>  p.ProductId == product.ProductId);
           
            if (searchproduct == null)
            {
                products.Add(product);
                writeproduct(products);
                return ($"id : {product.ProductId} , Name : {product.Name} , Barcode:{product.Barcode}");
            }
            else
            {
                throw new ReapetedIdException("this id is already exist");
            }



        }

        public string GetProductById(int id)
        {

            var validProduct = products.Find(u => u.ProductId == id);

            if (validProduct != null)
            {
                return ($" {validProduct.Name}");
            }
            else { throw new ProductNotFoundException("product not found"); }
        }

        public List<Product> GetProductList()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string jsonstr = reader.ReadToEnd();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsonstr);
                if (products != null )
                    foreach (var product in products)
                    {

                        Console.WriteLine(product);

                    }
                else
                    return null;


            }
            return products;
        }
        public void CheckProductName(string productName)
        {
            Regex regex = new Regex("^[A - Z][a - z]{ 2 }_[0 - 9]{ 3}$^");
            if (!regex.IsMatch(productName))
            {
                throw new NotValidProductNameException("name is not valid");
            }

        }
        public void writeproduct(List<Product> product)
        {
            using (var writer = new StreamWriter(path))
            {
                string jsonstr = JsonConvert.SerializeObject(product, Formatting.Indented);
                writer.Write(jsonstr);

            }


        }
    }
}
