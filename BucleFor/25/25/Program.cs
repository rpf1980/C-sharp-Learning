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
            int contador = 0;

            for(i = 1; i < 100; i ++)
            {
                if(i %2 == 0)
                {
                    contador++;
                    if(contador <= 10)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
