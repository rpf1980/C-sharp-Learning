using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31  // Aprobados / Suspensos para 30 alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int nota, suspensos, aprobados, i;
            i = 0;
            suspensos = 0;
            aprobados = 0;

            // Pedimos nº's
            //Console.Write("Escriba la nota: ");
            //nota = int.Parse(Console.ReadLine());
            // Pedimos notas hasta 30 alumnos
            for(i = 1; i <= 5; i++)
            {
                Console.WriteLine("Escriba la nota nº " + i + ": ");
                nota = int.Parse(Console.ReadLine());
                if (nota >= 0 && nota < 5)
                {
                    suspensos=suspensos+1;
                }
                else
                {
                    if (nota >= 5 && nota <= 10)
                    {
                        aprobados = aprobados + 1;
                    }
                }

            }
            Console.WriteLine("Tenemos {0} alumnos suspensos y {1} aprobados ",suspensos, aprobados);
            Console.ReadKey();
        }
    }
}
