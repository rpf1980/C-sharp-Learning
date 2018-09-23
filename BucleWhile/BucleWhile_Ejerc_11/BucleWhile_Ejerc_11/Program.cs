using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleWhile_Ejerc_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 0;

            while(i <= 20)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            Console.ReadKey();
        }
    }
}
