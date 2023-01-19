using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            A<int> oA = new A<int>();
            oA.Algo(4);

            A<string> oA2 = new A<string>();
            oA2.Algo("1");

        }

        public class A<T>
        {
            public void Algo(T unparametro)
            {

            }
        }
    }
}
