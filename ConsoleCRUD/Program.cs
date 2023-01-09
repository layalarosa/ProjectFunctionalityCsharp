using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleCRUD
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listadoDePersonas = new List<Persona>()
            {
                new Persona
                {
                    name = "Luis" ,
                    articulo = new Articulo
                    {
                        name = "Perro",
                        precio=400
                    }
                },

                new Persona
                {
                    name = "Pablo" ,
                    articulo = new Articulo
                    {
                        name = "Gato",
                        precio=300
                    }
                },

                new Persona
                {
                    name = "Maria" ,
                    articulo = new Articulo
                    {
                        name = "Rana",
                        precio=100
                    }
                }
            };
            
            // ANALIZAR
            // Para Evitar hacer tanto for loop pues con los DTO se evita hacerlos 
            

            //READ GET
            Persona personaBuscada = new Persona();
            for (int i = 0; i < listadoDePersonas.Count; i++)
            {
                Console.WriteLine(listadoDePersonas[i].articulo.precio);
                if (listadoDePersonas[i].name == "luis")
                {
                    //personaBuscada = listadoDePersonas[i];
                    listadoDePersonas[i].name = "luis";
                    break;
                }
                for (int a = 0; a < listadoDePersonas[i].articulos.Count; a++)
                {
                    Console.WriteLine(listadoDePersonas[i].articulos[a].name);
                    Console.WriteLine(listadoDePersonas[i].articulos[a].precio);

                    for (int w = 0; w < listadoDePersonas[i].articulos[a].piezas.Count; w++)
                    {

                    }

                }
            } // end for loop

            personaBuscada.name = "Luis";

            //POST
            listadoDePersonas.Add(new Persona());

            //PUT
            //listadoDePersonas.Find(h => h.Id == request.Id)

            

            //DELETE (lambda expression)
            var personaToDelete = listadoDePersonas.FirstOrDefault(new Persona().ss);

            //var personaToDelete = listadoDePersonas.Select( w => w.name == "luis");
            listadoDePersonas.Remove(personaToDelete);

        }
    }

    public class Persona
    {

        public string name { get; set; }
        public Articulo articulo { get; set; }

        public List<Articulo> articulos { get; set; }

        
        // lambda expression o una funcion Anonima
        public bool ss(Persona persona)
        {
            if (persona.name == "luis")
            {
                return true;
            }
            return false;
        }
    }

    public class Articulo
    {

        public string name { get; set; }
        public double precio { get; set; }
        public List<Piezas> piezas { get; set; }

    }

    public class Piezas
    {
        public string name { get; set; }
        public double precio { get; set; }

    }
}
