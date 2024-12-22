using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them 
//based on the price, and display the sorted Products
namespace Challenge_2
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { ProductId = 1, ProductName = "Laptop", Price = 50000 });
            products.Add(new Product { ProductId = 2, ProductName = "Mobile", Price = 25000 });

            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));


            Console.WriteLine("Sorted the Products");
            foreach(Product product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
            }
            Console.ReadLine();
        }
    }  
    

    
}
