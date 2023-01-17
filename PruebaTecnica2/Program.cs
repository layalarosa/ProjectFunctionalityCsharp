using System;

namespace PruebaTecnica2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console. 
            //for (int i = 1; i < 100; i++)
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i + ",");
            //        Console.ReadKey();
            //    }


            // Un número de palíndromo es un número que es igual después del reverso.
            //int n, r, sum = 0, temp;
            //Console.Write("Enter the Number: ");
            //n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = (sum * 10) + r;
            //    n = n / 10;
            //}
            //if (temp == sum)
            //    Console.Write("Number is Palindrome.");
            //else
            //    Console.Write("Number is not Palindrome");


            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            int a, b, limite, i, auxiliar;
            Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            limite = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
