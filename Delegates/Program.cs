using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    public class Program
    {
        // Implementacion del delegado
        public delegate int BuscaMayorNumero(List<int> lst);

        // Funcion que asigna el delegado
        static int BuscandoANemo(List<int> lst_)
        {
            return lst_.OrderByDescending(d => d).First();
        }

        static void Main(string[] args)
        {
            // Forma 1
            BuscaMayorNumero fn1 = BuscandoANemo;

            Console.WriteLine(fn1(new List<int> { 2, 3, 4, 6, 9, 666, 2, 1 }));

            // Forma 2
            //BuscaMayorNumero fn2 = delegate (List<int> lista)
            //{
            //    return lista.OrderByDescending(d => d).First();
            //};
            //Console.WriteLine(fn2(new List<int> { 2, 3, 4, 6, 999, 666, 2, 1 }));

            // Forma 3
            //BuscaMayorNumero fn3 = f => f.OrderByDescending(d => d).First();
            //Console.WriteLine(fn3(new List<int> { 2, 3, 4, 6, 9, 666, 2, 1 }));

            Console.Read();

        }
    }
}
