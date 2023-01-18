using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Operaciones
    {
        public int result = 0;

        public Operaciones()
        {

        }

        /*Declarar los numeros*/
        public int Suma(int valor1, int valor2)
        {


            this.result = valor1 + valor2;
            return result;
        }

        public int Resta(int valor1, int valor2)
        {

            this.result = valor1 - valor2;
            return result;
        }

        public int Multi(int valor1, int valor2)
        {

            result = valor1 * valor2;
            return result;
        }

        public int Divi(int valor1, int valor2)
        {

            result = valor1 / valor2;
            return result;
        }
    }
}
