using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[3]; //arreglo de tres elementos

            arreglo[0] = 0;
            arreglo[1] = 2;
            arreglo[2] = 4;

            Console.WriteLine(arreglo[0]);
            Console.ReadKey();
        }
    }
}
