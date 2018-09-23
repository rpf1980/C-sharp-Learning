using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41 /* Generalizar el algoritmo anterior para averiguar todos los números primos que existen 
                entre 2 y 1000.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numero, i, divisores;
            

            //Algoritmo
            for(numero = 2; numero <= 1000; numero++)
            {
                divisores = 0;
                i = 1;
                while (i <= numero)
                {
                    if (numero % i == 0)
                    {
                        divisores = divisores + 1;
                    }
                    i = i + 1;
                }

                if (divisores <= 2)
                {
                    Console.Write(numero +" ");
                } 
            }
            Console.ReadKey();
            


        }
    }
}
