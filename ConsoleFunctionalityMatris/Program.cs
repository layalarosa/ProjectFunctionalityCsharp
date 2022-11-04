using System;

namespace ConsoleFunctionalityMatris
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var personas = new[]
            //{
            //    new { Nombre = "Noel", Edad = 20},
            //    new { Nombre = "Kira", Edad = 25},
            //    new { Nombre = "Carlos", Edad = 27}

            //};

            //var valores = new[] { 2, 5, 6, 7.5, 8.5, 10, 11, 12, 13.5, 15 };

            //for(int i = 0; i < 10; i++) 
            //{
            //    Console.WriteLine(valores[i]);
            //}
            //Console.WriteLine("Hello World!");


            // Arreglos Unidimencional
            //int[] numero;

            //numero = new int[5];

            //numero[0] = 5;
            //numero[2] = 6;
            //numero[4] = 7;

            //for(int i = 0; i < 5; i++) 
            //{
            //    Console.WriteLine(numero[i]);
            //}

            // Arreglos Bidimencional
            int[,] numero;

            numero = new int[3, 3];

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; fila++)
                {
                    Console.WriteLine("Inserta un Numero: ");
                    numero[fila, col] = Convert.ToInt16(Console.ReadLine());
                }
            }


            Console.Clear();

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; fila++)
                {
                    Console.WriteLine(" " + numero[fila, col]);

                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
