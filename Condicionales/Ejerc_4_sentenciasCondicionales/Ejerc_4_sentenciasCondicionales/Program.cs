using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_4_sentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int x, y, z;

            // Leemos esos tres números
            Console.WriteLine("Dime un número");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime otro");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame un tercer número");
            z = int.Parse(Console.ReadLine());

            // Condición
            if ((z > y && y > x)){

                Console.WriteLine("Los números " + x + ", " + y + ", " + z + " están ordenados de menor a mayor");
            }
            else
            {
                Console.WriteLine("Los números " + x + ", " + y + ", " + z + " no están ordenados de menor a mayor");  
            }
            Console.ReadKey();
        }
    }
}
