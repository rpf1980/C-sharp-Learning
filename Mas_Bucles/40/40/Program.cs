using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40  //Escribe un programa que nos diga si un número es primo o no.
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, numero, divisores;
            divisores = 0;
            //Pedimos nº
            Console.Write("Escriba un nº para saber si es primo o no: ");
            numero = int.Parse(Console.ReadLine());
            
            
            //Condiciones            
            i = 1;
            while(i <= numero)
            {
                if (numero % i == 0)
                {
                    divisores = divisores + 1;
                }
                i = i + 1;
            }

            Console.WriteLine("Divisores = " + divisores);

            if (divisores > 2)
            {
                Console.WriteLine("El nº no es primo");
            }
            else
            {
                Console.WriteLine("El nº es primo");
            }
            Console.ReadKey();
        }
    }
}
