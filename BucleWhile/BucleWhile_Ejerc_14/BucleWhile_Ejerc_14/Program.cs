using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleWhile_Ejerc_14  /*Escribe un programa que te pida dos números con la condición de que el segundo sea
                                mayor que el primero, en caso contrario te pregunta de nuevo el número hasta que sea
                                correcto. Si los números son correctos, escribe todos los números comprendidos entre
                                el primer y el segundo número (ambos inclusive).*/
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable
            int n1, n2;

            // Preguntamos
            Console.Write("Escriba un número, por favor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Inserte un segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            while (n1 > n2)
            {
                Console.WriteLine("No entendiste la prueba, debe introducir dos números de menor a mayor");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());

            }

            // Condiciones 
            while (n1 <= n2)
            {
                
                Console.WriteLine(n1);                
                n1 = n1 + 1;
            }
            
            Console.ReadKey();
            
        }
    }
}
