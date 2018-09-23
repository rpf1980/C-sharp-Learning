using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones13  /* Escribe una función “NotaEnTexto” a la que le pasamos la nota de un alumno como un 
                    double y nos devolverá la calificación en formato texto (“aprobado”, “suficiente”, etc.). */
{
    class Program
    {
        /// <summary>
        /// Función determina la nota de alumnos. Expresa la calificación mediante suspenso, suficiente, notable, sobresaliente.
        /// </summary>
        /// <param name="nota">Variable asignada para nota del alumno y determina el parámetro de la función</param>
        /// <returns>Devuelve valor string de la opción de la nota del alumno</returns>
        static string NotaEnTexto(double nota)
        {
            string texto;
            if(nota >= 0 && nota < 5)
            {
                texto = "suspenso";            
            }
            else
            {
                if(nota >= 5 && nota <= 7)
                {
                    texto = "suficiente";
                }
                else
                {
                    if(nota >= 8 && nota < 9)
                    {
                        texto = "notable";
                    }
                    else
                    {
                        if(nota >= 9 && nota == 10)
                        {
                            texto = "sobresaliente";
                        }
                        else
                        {
                            texto = "nota no válida";
                        }
                    }
                }                
            }

            return texto;

        }

        static void Main(string[] args)
        {
            double nota;
            Console.WriteLine("Escribe la nota del alumno: ");
            nota = double.Parse(Console.ReadLine());
            Console.WriteLine("El alumno tiene una notad de: " + NotaEnTexto(nota));
            Console.ReadKey();
        }
    }
}
