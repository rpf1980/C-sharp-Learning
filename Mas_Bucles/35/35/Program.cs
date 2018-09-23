using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35 /*Escribe un programa que le pide al usuario la nota de un alumno (un número real). El
programa escribirá “Suspenso” si la nota está entre 0 y 5; “Suficiente” si la nota está
entre 5 y 6; “Bien” si la nota está entre 6 y 7; “Notable” si la nota está entre 7 y 9 y
“Sobresaliente” si está entre 9 y 10. Si la nota no es válida, el programa nos vuelve a
pedir un valor hasta que introduzcamos una correcta.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double nota;

            //Pedimos nota
            Console.Write("Escriba la nota del alumno: ");
            nota = double.Parse(Console.ReadLine());


            while (nota < 0 || nota > 10)
            {
                Console.Write("El valor introducido no es válido, escriba un nº entero para la nota ( entre el 0 y el 10): ");
                nota = double.Parse(Console.ReadLine());
            }

            //Algoritmo


            if (nota >= 0 && nota < 5)
            {
                  Console.WriteLine("Suspenso");
            }
            else
            {
                if (nota >= 5 && nota < 6)
                {
                    Console.WriteLine("Suficiente");
                }
                else
                {
                    if (nota >= 6 && nota < 7)
                    {
                        Console.WriteLine("Bien");
                   }
                    else
                    {
                        if (nota >= 7 && nota < 9)
                        {
                            Console.WriteLine("Notable");
                        }
                        else
                        {
                            if (nota >= 9 && nota <= 10)
                            {
                                Console.WriteLine("Sobresaliente");
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
