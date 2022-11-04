using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mini Calculadora - Luis Ayala";
            string resp = ""; //Esta variable nos servira para salir de la aplicacion.
            while (resp.ToLower() != "s")
            {
                // Cree el objecto y almacenes las operaciones
                Operaciones Operaciones = new Operaciones();
                int valor1, valor2;

                Console.WriteLine("Presione el simbolo para realizar la operacion:n");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.WriteLine("= para dividir");

                Console.WriteLine(" Eliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);

                Console.WriteLine();

                if (eleccion == "+")
                {
                    Console.WriteLine("Ingrese sus dos numeros");
                    Console.WriteLine("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado de la suma es:");
                    Operaciones.Suma(valor1, valor2);
                    Console.WriteLine(Operaciones.result);
                }
                if (eleccion == "-")
                {
                    Console.WriteLine("Ingrese sus dos numeros");
                    Console.WriteLine("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado de la suma es:");
                    Operaciones.Resta(valor1, valor2);
                    Console.WriteLine(Operaciones.result);
                }
                if (eleccion == "*")
                {
                    Console.WriteLine("Ingrese sus dos numeros");
                    Console.WriteLine("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado de la suma es:");
                    Operaciones.Multi(valor1, valor2);
                    Console.WriteLine(Operaciones.result);
                }
                if (eleccion == "/")
                {
                    Console.WriteLine("Ingrese sus dos numeros");
                    Console.WriteLine("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado de la suma es:");
                    Operaciones.Divi(valor1, valor2);
                    Console.WriteLine(Operaciones.result);
                }

                if (eleccion == "=")
                {
                    Console.WriteLine("Los Ultimos resultado son:");
                    StreamReader sReader = new StreamReader(@"C:\Users\layal\Desktop\CSVBDCalculadora\CSVBDCalculadora1.txt");
                    while (!sReader.EndOfStream)
                    {
                        Console.WriteLine(sReader.ReadLine());
                    }
                    sReader.Close();

                }

                DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\layal\Desktop\CSVBDCalculadora");
                if (directoryInfo.Exists)
                {

                }
                else
                {
                    directoryInfo.Create();
                }

                FileInfo fileInfo = new FileInfo(@"C:\Users\layal\Desktop\CSVBDCalculadora\CSVBDCalculadora1.txt");

                if (fileInfo.Exists)
                {
                    var gg = fileInfo.AppendText();
                    gg.WriteLine(Operaciones.result);
                    gg.Close();
                }
                else
                {
                    fileInfo.Create();
                }

                Console.Write("¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();

            }
        }
    }
}
