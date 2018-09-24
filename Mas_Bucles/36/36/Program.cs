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

            i = 0;
            while(i < 100)
            {
               if(i %2 != 0 && i %3 != 0)
                {
                    contador++;
                    if(contador <= 10)
                    {
                        Console.WriteLine(i);
                    }
                }
                i++;
            }
            Console.ReadKey();
            


        }
    }
}
