using System;

namespace ConsoleFunctionalityMatris
{
    public class Program
    {
        static void Main(string[] args)
        {
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
