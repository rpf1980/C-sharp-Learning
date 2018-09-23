using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26 // Pregunta si pares/impares.... 10 primeros nº pares para pares... 10 primeros nº impares para impares.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string opcion;
            int i;

            i = 0;
            

            Console.WriteLine("PARES o IMPARES");
            opcion = Console.ReadLine();

            if ( opcion == "PARES")
            {
                for (i = 2; i <= 10; i=i+2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                if (opcion == "IMPARES")
                {
                    for (i = 1; i <= 10; i=i+2)
                    {
                        Console.WriteLine(i); 
                    }
                }
            }
            Console.ReadKey();


        }
    }
}
