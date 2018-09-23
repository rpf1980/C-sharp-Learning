using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25 // Muestre los 10 primeros nº pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 0;

            for(i = 2; i <=20; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
