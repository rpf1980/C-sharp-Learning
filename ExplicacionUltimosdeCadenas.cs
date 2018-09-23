using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 19
            // Invertir cada palabra dentro de una cadena

            // 1- Hacer un split y obtener un array con
            //    cada palabra por separado

            // 2- En ese array, cada palabra la vas invirtiendo
            //    con la función que ya tienes hecha (14)

            // 3- Una vez invertidas, vas pegando las palabras
            //    en otra cadena "resultado".

            // 3b- Otra opción es usar el join para pegarlo
            //     todo.


            // 18 - MarcaSubCadena
            // "el camaleón está en la cama"
            // subcadena: "cama"
            // "el *amaleón está en la *ama"

            // Tres maneras:
            // 1) Usando un for y substring
            // Vamos recorriendo el array con un for
            // y cogiendo subcadenas de tamaño 4 (como "cama")
            // (o el largo que sea)
            // Ej: A partir de la posición 0, cogeríamos: "el c"
            //     como no corresponde a la subcadena lo dejamos así
            //     A partir de la posición 1, cogemos "l ca"
            //     etc.
            //     A partir de la posición 3, cogemos "cama"
            //     entonces sustituimos la primera por un "*"

            // 2) Usando la función IndexOf

            string cadena = "el camaleón está en la cama";
            string subcadena = "cama";
            int pos = cadena.IndexOf(subcadena);

            // El IndexOf devuelve -1 si no está (hemos acabado)
            // o la posición de la primera letra.

            // 3) Usando Replace
            string subcadena2 = "*ama";
            string resultado = cadena.Replace(subcadena, subcadena2);




        }
    }
}
