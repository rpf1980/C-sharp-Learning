using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programas para profesor --> Aprobados - Suspensos ---> 30 Alumnos

            // Variables
            int notas, susp, apro, i;
            apro = 0;
            susp = 0;

            i = 0;
            
            // Condiciones
            while(i < 30)
            {
                Console.Write("Introduce NOTA: ");
                notas = int.Parse(Console.ReadLine());

                if (notas >= 5)
                {
                    apro = apro + 1;                   
                }
                else
                {
                    susp = susp + 1;                    
                }

                i = i + 1;
            }

            Console.WriteLine("Son " + apro + " los alumnos aprobados.");
            Console.WriteLine("Son " + susp + " los alumnos suspensos.");
            Console.ReadKey();

            
            



        }
    }
}
