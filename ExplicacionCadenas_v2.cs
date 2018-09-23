using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionCadenas_v2
{
    class Program
    {
        static string Subestrin(string cadena, int pos)
        {
            string resultado = "";
            int i;

            for (i = pos; i < cadena.Length; i++)
            {
                resultado = resultado + cadena[i];
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            // Cadenas
            // Son estructuras de datos
            // Son homogéneas: todos los datos del mismo tipo (carácter)
            // Son estáticas: no pueden cambiar de tamaño

            // El funcionamiento es parecido a los arrays con unas poquitas
            // diferencias

            // Parecidos con los arrays: para acceder a la posición de una cadena

            string s = "patata"; // dos comillas = cadena de caracteres

            Console.WriteLine(s[2]);

            int i;
            for (i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            // Diferencia principal con un array: los elementos no se pueden
            // modificar

            //s[0] = 'P'; // una comilla: un caracter
            string s1 = 'P' + s.Substring(1);
            s1 = 'P' + s.Remove(0, 1);
            //s1 = s.Remove(0, 1).Insert(0, "P");
            //s1 = s.Insert(1, s[0].ToString().ToUpper()).Remove(0, 1);
            
            Console.WriteLine(s1);

            // ¿Cómo modificar una cadena?

            // Técnica nº1: usando el operador de concatenación '+'

            string s2 = "cama";
            string s3 = "león";
            string s4 = s2 + s3;

            Console.WriteLine(s4);

            // Ej: Poner en una cadena los números del 1 al 10
            string s5 = "";

            for (i = 1; i <= 10; i++)
            {
                s5 = s5 + i + ',';
            }

            Console.WriteLine(s5);

            // Ej: Poner en una cadena las letras de la 'a' a la 'z'
            string s6 = "";
            char c;

            for (c = 'a'; c <= 'z'; c++)
            {
                s6 = s6 + c;
            }

            Console.WriteLine(s6);


            // Técnica 2: usando las funciones de cadenas

            // Insertar o borrar un caracter
            string s7 = "placa";

            // Esta función nos devuelve una cadena modificada pero no
            // modifica la cadena original. En este ejemplo no estamos 
            // haciendo nada realmente
            s7.Remove(1, 3);

            // Para guardar el resultado tenemos que asignarlo en otra
            // cadena (que puede ser la misma si queremos)
            s7 = s7.Remove(1, 3);

            Console.WriteLine(s7);

            // Para insertar
            s7 = s7.Insert(1, "ap");

            Console.WriteLine(s7);

            // Subcadena = recorta un cacho de la cadena original
            string s8 = "mi mamá me mima";
            string s9 = s8.Substring(8); // empezando en la posición 8
                                         // hasta el final

            Console.WriteLine(s9);

            string s10 = s8.Substring(3, 4); // empezando en la posición 3
                                             // cogemos 4 caracteres
            Console.WriteLine(s10);

            // Más funciones
            // Búsqueda: Contains, Index
            // Contains = nos dice si en una cadena está el caracter que buscamos
            //            devuelve true o false
            string s11 = "sí";

            if (s11.Contains('s'))
            {
                Console.WriteLine("Has dicho \"sí\"");
            }

            string s12 = "mi mamá me mima";

            if (s12.Contains("mamá"))
            {
                Console.WriteLine("¡Mi mamá me mima!");
            }

            // IndexOf = nos dice en qué posición está algo
            //           si no está te devuelve = -1

            string s13 = "hola que tal";

            int pos1 = s13.IndexOf(' ');
            Console.WriteLine(pos1);

            string s14 = 
                "<html><head><title>Patata</title></head><body></body></html>";

            int pos2 = s14.IndexOf("<title>") + "<title>".Length;
            int pos3 = s14.IndexOf("</title>");

            string s15 = s14.Substring(pos2, pos3 - pos2);
            Console.WriteLine(s15);

            // Más funcioncitas
            // Replace
            string s16 = "patata";
            s16 = s16.Replace('p', 'b');
            s16 = s16.Replace('t', 'n');

            Console.WriteLine(s16);

            // ToUpper,ToLower
            // Sirven para poner en mayúsculas o en minúsculas toda la cadena
            string s17 = "PaTaTa";
            Console.WriteLine(s17);
            Console.WriteLine(s17.ToUpper());
            Console.WriteLine(s17.ToLower());
            Console.WriteLine(s17);

            // Trims
            // Sirven para quitar los espacios del principio y del final 
            // de una cadena
            string s18 = "     hola hola     ";
            Console.WriteLine(">" + s18 + "<");
            Console.WriteLine(">" + s18.TrimStart() + "<");
            Console.WriteLine(">" + s18.TrimEnd() + "<");
            Console.WriteLine(">" + s18.Trim() + "<");

            // Pads
            // Sirve para añadir espacios: se usa principalmente para
            // alinear en columnas. El valor que le pasas es el total de 
            // caracteres final que va a tener la cadena y la función te
            // rellena con espacio hasta llegar al tamaño

            Console.Write("Pedro".PadRight(12));
            Console.WriteLine("9.3".PadLeft(5)); // "  9.3"
            Console.Write("Juan Carlos".PadRight(12));
            Console.WriteLine("10.0".PadLeft(5));// " 10.0"
            Console.Write("Ana".PadRight(12));
            Console.WriteLine("0.5".PadLeft(5)); // "  0.5"
            

            // Funciones PRO: split, join
            
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
