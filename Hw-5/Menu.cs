using Hw_5.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Hw_5.InterFace;

namespace Hw_5
{
    public class Menu
    {
        ProductRepository Productrepo = new ProductRepository();
        List<Product> Products;
        Product product = new Product();
        public void MainMenu() 
        {
            Console.WriteLine("welcome to the program");
            Console.WriteLine("choose your action");
            Console.WriteLine("press 1 for adding product");
            Console.WriteLine("press 2 for search product by id");
            Console.WriteLine("press 3 for see productlist");
            int key = Convert.ToInt32(Console.ReadLine());
            if(key == 1) 
            {
            AddProducts();
            }
            else if(key == 2) 
            {
            SearchById();
            }
            else if(key == 3) 
            {
            
            }
        }
        public void AddProducts()
        {
            Console.WriteLine("enter num of products that you want add");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("enter the name of product");
                product.Name = Console.ReadLine();
                Console.WriteLine("enter the id of products");
                product.ProductId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the barcod of product");
                product.Barcode = Convert.ToInt32(Console.ReadLine());
                Productrepo.AddProduct(product);
            }
           Console.Clear();
            MainMenu();

        }
        public void SearchById()
        {
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Productrepo.GetProductById(id);
        }
    }
}
