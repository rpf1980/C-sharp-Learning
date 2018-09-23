using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24  // Nos escriba los números impares comprendidos entre 1 y 10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 0;

            for (i = 1; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
