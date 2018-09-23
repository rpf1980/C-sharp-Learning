using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionCadenas2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Como ir generando las cadenas
            // con el operador + -> concatenación

            // Ej: Crear una cadena con los números del 0 al 9

            int i;
            string cadena = "";

            for (i = 0; i <= 9; i++)
            {
                cadena = cadena + i;
            }

            Console.WriteLine(cadena);

            // Ej: Crear una cadena con las letras de la A a la Z

            string cadena2 = "";
            char letra = 'A';

            for (i = 0; i < 26; i++)
            {
                cadena2 = cadena2 + letra;
                letra++;
            }

            Console.WriteLine(cadena2);


            // Split / Join -----------------------------------

            string fecha = "30/11/2017";
            Console.WriteLine(fecha);

            //for (i = 0; i < fecha.Length; i++)
            //{
            //    if (fecha[i] == '/')
            //    {
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.Write(fecha[i]);
            //    }                
            //}
            //Console.WriteLine();

            // Split nos parte una cadena en trozos
            // Nos devuelve un array de cadenas
            // Al split le pasamos un separador que es el que va a
            // usar para cortar la cadena en trozos.

            string[] array;

            array = fecha.Split('/');

            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int dia = int.Parse(array[0]);
            int mes = int.Parse(array[1]);
            int anno = int.Parse(array[2]);

            // Join hace todo lo contrario, que es recomponer una
            // cadena en base a unos trozos y un separador
            
            string fecha2;
            
            fecha2 = string.Join("-", array);
            Console.WriteLine(fecha2);

            Console.ReadKey();
        }
    }
}
