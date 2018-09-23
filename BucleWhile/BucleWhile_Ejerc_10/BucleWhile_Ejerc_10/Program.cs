using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleWhile_Ejerc_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Impares entre el 1 y 10
            int i;
            i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            Console.ReadKey();
        }
    }
}
