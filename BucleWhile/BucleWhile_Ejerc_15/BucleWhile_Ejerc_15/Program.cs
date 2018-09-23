using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleWhile_Ejerc_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int n1, n2;

            // Preguntamos
            Console.Write("Introduzca un número por pantalla: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Clear();
            // Condicion --> el primero MENOR... imprimir nº en orden ascendente incluidos n1 y n2
            while(n1 <= n2)
            {
                Console.WriteLine(n1);
                n1 = n1 + 1;
            }
            // Condición --> el primero MAYOR... imprimir nº en orden descendente
            while(n1 >= n2)
            {
                Console.WriteLine(n1);
                n1 = n1 - 1;
            }
            Console.ReadKey();


        }
    }
}
