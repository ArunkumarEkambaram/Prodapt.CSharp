using System;

namespace Prodapt.CSharp.Day5
{
    internal class Product
    {
        public const double price = 10000.50;
        public readonly double newPrice = 5000.66;

        public Product()
        {
            //price = 1000;
            newPrice = 6000.5;
        }

        //public void Modify()
        //{
        //    price = 55;
        //    newPrice = 5000.666;
        //}

        static void Main(string[] args)
        {            
            Console.WriteLine($"Price :{Product.price}");
            Console.WriteLine($"New Price :{new Product().newPrice}");
        }
    }
}
