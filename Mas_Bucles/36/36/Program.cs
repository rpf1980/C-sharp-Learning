using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36  /*Escribe un programa que nos escriba los 10 primeros números que no sean múltiplos ni
                de 2 ni de 3.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contadores... para el bucle y otro para los múltiplos
            int i, contador;
            contador = 0;

            i = 1;
            while(i < 100)
            {
               if(i %2 != 0 && i %3 != 0)
                {
                    Console.WriteLine(i);
                    contador = contador + 1;
                }
                i = i + 1;
            }
            Console.ReadKey();
            


        }
    }
}
