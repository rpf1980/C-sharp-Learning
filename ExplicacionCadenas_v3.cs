using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicación_de_Cadenas_v3
{
    class Program
    {
        // Si queremos modificar una cadena en una función, tenemos 
        // que pasarle una cadena y nos devuelve otra cadena
        // con el resultado
        // No funciona igual que los arrays

        static string QuitaPrimeraLetra(string cadena)
        {
            string cadena2 = cadena.Remove(0, 1);
            return cadena2;
        }
        

        static void Main(string[] args)
        {
            string s = "Hola";
            Console.WriteLine(s);
            Console.WriteLine(QuitaPrimeraLetra(s));
            Console.WriteLine(s);

            // Para modificar la cadena original
            s = QuitaPrimeraLetra(s);

            // ----------------------------------------------
            // Como modificar un caracter de una cadena

            string s2 = "Mi mamá me mima";

            // Esto no funciona, las cadenas no se pueden modificar
            // s2[2] = '_';

            // Método 1 = Usando un for y copiando poco a poco la cadena
            int i;
            string resultado = "";

            for (i = 0; i < s2.Length; i++)
            {
                if (s2[i] == ' ')
                {
                    resultado = resultado + '_';
                }
                else
                {
                    resultado = resultado + s2[i];
                }
            }

            Console.WriteLine(resultado);

            // Método 2 = Usando las funciones de cadenas
            string s3 = "Yo mimo a mi mamá";

            //s3 = s3.Remove(2, 1);
            //s3 = s3.Insert(2, "_");
            //Console.WriteLine(s3);

            for (i = 0; i < s3.Length; i++)
            {
                if (s3[i] == ' ')
                {
                    s3 = s3.Remove(i, 1);
                    s3 = s3.Insert(i, "_");
                }
            }

            Console.WriteLine(s3);

            for (i = 0; i < s3.Length; i++)
            {
                if (s3[i] == '_')
                {
                    s3 = s3.Substring(0, i) // Cogemos hasta nuestra posición (sin incluirla)
                        + "-" 
                        + s3.Substring(i + 1); // Cogemos desde la posición siguiente hasta el final
                }
            }
            
            Console.WriteLine(s3);

            // ----------------------------------------------------------

            // Trabajar con palabras

            // La manera más fácil de trabajar con palabras separadas por
            // espacios es usando las funciones SPLIT y JOIN

            // Ej: Escribir cada palabra en una línea
            string s4 = "El   patito llora";

            string[] palabras = s4.Split(' ');

            for (i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] != "")
                {
                    Console.WriteLine(i + "- " + palabras[i]);
                }
            }

            // Ej: Ahora con más signos de puntuación
            string s5 = "El cielo es  azul,las nubes blancas.";
            string[] separadores = { " ", ",", "." };

            string[] palabras5 = s5.Split(separadores, 
                StringSplitOptions.RemoveEmptyEntries);

            for (i = 0; i < palabras5.Length; i++)
            {
                Console.WriteLine(palabras5[i]);
            }

            // No es lo mismo una cadena con un caracter que un
            // caracter suelto

            string s6 = "a";
            char c6 = 'a';

            // Añadir un espacio delante de una cadena

            string s7 = "Mi mamá ya no me mima";
            s7 = " " + s7;

            // Otra forma

            s7 = s7.Insert(0, " ");

            Console.ReadKey();
        }
    }
}
