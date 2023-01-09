using System;
using System.Collections.Generic;

namespace MoreTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Collection List
            var list = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    ProductName = "Mono",
                }
            };

            //Get
            Product MostrarProducto = new Product();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Id);
                Console.WriteLine(list[i].ProductName);

                if (list[i].ProductName == "Mono")
                {
                    list[i].ProductName = "Mono";
                    break;
                }

            }

            MostrarProducto.ProductName = "Mono";
            Console.ReadKey();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

    }
}
