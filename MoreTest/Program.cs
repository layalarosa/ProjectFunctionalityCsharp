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
                },

                new Product
                {
                    Id = 2,
                    ProductName = "Sapo",
                }
            };

            //Get All
            Product MostrarProducto = new Product();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Id);
                Console.WriteLine(list[i].ProductName);
            }

            //Get

            //Post
            // Esto no es una buena forma debido a el orm o la base de datos crea la id
            Console.WriteLine("Inserte la Id del Producto");
            var Id = Console.ReadLine();
            Console.WriteLine("Inserte el nombre del Producto");
            string ProductName = Console.ReadLine();

            list.Add(new Product());

            
            for (int i = 0; i < list.Count; i++)
            {
                
                Console.WriteLine(list[i].Id);
                Console.WriteLine(list[i].ProductName);
            }

            //Put

            //Delete


        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

    }
}
