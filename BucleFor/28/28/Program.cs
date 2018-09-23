using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28  // Dos nº... Si 1º mayor --> ascendentes entre nº's pedidos.... Si 1º menor --> descendentes entre nº's pedidos 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numero1, numero2;
         
            // Pedimos nº's
            Console.Write("Introduce el primer nº: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo nº: ");
            numero2 = int.Parse(Console.ReadLine());

            // Condiciones
            if (numero1 < numero2)
            {
                for (numero1 = numero1; numero1 <= numero2; numero1 = numero1 + 1)
                {
                    Console.WriteLine(numero1);
                }
            }
            else
            {
                if (numero1 > numero2)
                {
                    for (numero1 = numero1; numero1 >= numero2; numero1 = numero1 - 1)
                    {
                        Console.WriteLine(numero1);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
