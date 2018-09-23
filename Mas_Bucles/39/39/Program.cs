using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39  //Escribe un programa que calcule el mínimo común múltiplo de 2 números.
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, mcm, n1, n2;
            mcm = 0;

            //Pedimos nº's
            Console.WriteLine("Escriba dos nº para calcular su m.c.m: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
           
            i = n1;
            while(!(i % n1 == 0 && i % n2 == 0))
            {
                i++;
            }
            mcm = i;

            Console.WriteLine();
            Console.Write(mcm);
            Console.ReadKey();

        }
    }
}
