using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27  // Progr. que escriba la tabla de multiplicar del nº que introduzcas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int i, j, x;

            j = 1; // Contador ---> por 1, por 2, por 3...
            i = 1; // Contador de vueltas de bucle

            // Pedimos el nº 
            Console.Write("Introduzca un nº para obtener su tabla de multiplicar: ");
            x = int.Parse(Console.ReadLine());

            //  Inic. Cond. Increm.
            for(i = 1; i <= 20; i++)
            {
                Console.WriteLine("" + x + " x " + j + " = " + x * j);
                i = i + 1;
                j = j + 1;
            }
            Console.ReadKey();






        }
    }
}
