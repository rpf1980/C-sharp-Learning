using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34  // Calcular Factorial de un nº
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable
            int numero, factorial, i;
            factorial = 1;
            // Pedimos nº
            Console.WriteLine("Escribe un nº: ");
            numero = int.Parse(Console.ReadLine());

            //i = 1;
            //while (i <= numero)
            //{               
            //    factorial = factorial * i;
            //    i = i + 1;
            //}

            for (i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
            Console.ReadKey();


        }
    }
}
