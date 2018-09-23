using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            byte var1 = 9;
            byte var2 = 5;

            Console.WriteLine("9 entre 5 cabe a " + (var1 / var2) + " y el resto es de " + (var1 % var2));
            Console.ReadKey();
        }
    }
}
