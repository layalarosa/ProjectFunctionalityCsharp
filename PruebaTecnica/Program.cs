using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PruebaTecnica
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.- Invertir una cadena
            string text = "pato";
            string textResult = "";

            // A.forma por medio de un for 

            //for (int i= text.Length-1; i>=0; i--)
            //{
            //    textResult += text[i];
            //}

            // B.por medio del metodo Reverse

            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            textResult = new string(chars);

            Console.WriteLine(textResult);

            
            // 2. Cuantas veces se repite un caracter

            string text2 = "iausioAAduhsdjqaaaddsdsSJAK88192aasa";
            char character = 'A';

            int n = 0;

            // A.

            //foreach (var c in text2)
            //{
            //    if (c == character)
            //        n++;
            //}

            // B.

            n = text2.Where(c => c == character).Count();

            Console.WriteLine($"se repite la letra {character} {n} veces");

            
            // 3. Distancia de Hamming

            string text3 = "patitosw";
            string text4 = "paratosa";

            int distance = 0;

            if (text3.Length != text4.Length)
                throw new Exception("Longitudes Distintas");

            // A.

            for (int i = 0; i < text3.Length; i++)
            {
                if (text3[i] != text4[i])
                    distance++;
            }

            Console.WriteLine("Distancia es de: " + distance);

            
            // 4. Contador de Palabras

            string text5 = "  un   texto    que         tiene palabras   ";
            int n2 = 0;

            text5 = Regex.Replace(text, @"\s+", " ").Trim();
            var words = text5.Split();
            n2 = words.Length;

            Console.WriteLine("Numero de palabras: " + n);

            
            // 5. Contar Numeros

            string text6 = "an1298jq???da%22121230001masA";
            string pattern = @"[a-zA-Z";
            var regex = new Regex(pattern);
            int n3 = regex.Matches(text6).Count;

            Console.WriteLine("cantidad: " + n3);


            // 6. Cola

            Queue<string> Cola = new Queue<string>();

            Cola.Enqueue("Juan");
            Cola.Enqueue("Pedro");
            Cola.Enqueue("Raul");

            while (Cola.Count > 0)
            {
                Console.WriteLine(Cola.Dequeue());
            }




            // 6. Pila
            Stack<string> Pila = new Stack<string>();

            Pila.Push("Plato 1");
            Pila.Push("Plato 2");
            Pila.Push("Plato 3");

            while (Pila.Count > 0)
            {
                Console.WriteLine(Pila.Pop());
            }


        }
    }
}
