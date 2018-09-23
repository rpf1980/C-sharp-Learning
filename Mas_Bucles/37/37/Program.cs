using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37 /*Escribe un programa que nos presente un menú con 3 opciones. Eligiendo la opción “a”
                nos escribirá todos los múltiplos de 11 comprendidos entre 1 y 100. Eligiendo la opción
                “b”, lo mismo pero con los múltiplos de 17. Eligiendo la opción “c”, lo mismo pero con
                los múltiplos de 23.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string opcion;
            int i;

            //Mostramos menú de opciones
            Console.WriteLine("Eliga su opción: ");
            Console.WriteLine("A ---> nos escribirá todos los múltiplos de 11 comprendidos entre 1 y 100");
            Console.WriteLine("B ---> los múltiplos de 17");
            Console.WriteLine("C ---> los múltiplos de 23");
            opcion = Console.ReadLine();

            //Algoritmo
            if(opcion == "A")
            {
                for(i = 11; i <= 100; i = i + 11)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                if (opcion == "B")
                {
                    for(i = 17; i <= 100; i = i + 17)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    if (opcion == "C")
                    {
                        for(i = 23; i <=100; i = i + 23)
                        {
                            Console.WriteLine(i);
                            
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
