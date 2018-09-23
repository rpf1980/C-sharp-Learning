using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones2
{
    class Program
    {
        /// <summary>
        /// Función que calcula el área de un triángulo.
        /// </summary>
        /// <param name="b">Determina el primer parámetro de la función.</param>
        /// <param name="h">Determina el segundo parámetro de la función.</param>
        /// <returns>Devuelve resultado del cálculo de la fórmula del área del triángulo.</returns>
        static int AreaTriangulo(int b, int h)
        {
            int area = (b * h) / 2;
            return area;
        }

        /// <summary>
        /// Función que realiza conversión de pulgadas a centímetros.
        /// </summary>
        /// <param name="x">Variable asignada para el nº que el usuario ingresa por consola. Pertenece al único parámetro para la función</param>
        /// <returns>Devuelve resultado de la conversión pulagadas a centímetros</returns>
        static double PulgadasAcentimetros(double x)
        {
            const double cent = 2.54;
            double resultado = x * cent;
            return resultado;
        }

        /// <summary>
        /// Función que convierte centímetros a pulgadas.
        /// </summary>
        /// <param name="x">Determina el parámetro de la función</param>
        /// <returns>Devuelve resultado de la conversión.</returns>
        static double CentimetrosApulgadas(double x)
        {
            const double cent = 2.54;
            double resultado = x / cent;
            return resultado;
        }

        /// <summary>
        /// Función que lee la nota de un alumno y muestra calificación por consola.
        /// </summary>
        /// <param name="nota">Determina el parámetro de la función.</param>
        /// <returns>Devuelve calificación de alumno según la nota.</returns>
        static string NotaEnTexto(double nota)
        {

            string calificacion;
            if (nota >= 0 && nota < 5)
            {
                calificacion = "Suspenso";
            }
            else
            {
                if(nota >= 5 && nota <= 7)
                {
                    calificacion = "Suficiente";
                }
                else
                {
                    if(nota > 7 && nota < 9)
                    {
                        calificacion = "Notable";
                    }
                    else
                    {
                        if(nota >= 9 && nota <= 10)
                        {
                            calificacion = "Sobresaliente";
                        }
                        else
                        {
                            calificacion = "Nota no válida";
                        }
                    }
                }
                
            }
            return calificacion;
        }

        /// <summary>
        /// Función que lee un nº natural pro teclado, pero si es 0 ó negativo vuelve a pedir el nº.
        /// </summary>
        /// <param name="numero">Determina parámetro de la función.</param>
        static int LeeNatural()
        {
            int numero;
            Console.WriteLine("Escriba un nº, por favor: ");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0)
            {
                Console.WriteLine("Se necesita nº positivo para el ejercicio");
                Console.WriteLine("Vuelva a escribir otro nº: ");
                numero = int.Parse(Console.ReadLine());
            }
            return numero;
                       
        }

        /// <summary>
        /// Función que determina si un nº escrito por consola está en cierto rango de otro dos nº's también escritos por el usuario.
        /// </summary>
        /// <param name="min">Parámetro de la función que designa el valor mínimo requerido para el rango del ejercicio</param>
        /// <param name="max">Parámetro de la función que designa el valor máximo requerido para el rango del ejercicio</param>
        /// <returns></returns>
        static int LeeNumero(int min, int max)
        {
            int n;
            Console.WriteLine("Escriba un número que se encuentre en el rango del ejercicio");
            n = int.Parse(Console.ReadLine());

            // while (n < min || n > max)
            while (!(n >= min && n <= max))
            {
                Console.WriteLine("El nº escrito no se encuentra en el rango requerido, escriba otro por favor");
                n = int.Parse(Console.ReadLine());

            }
            return n;
        }

        /// <summary>
        /// Función que calcula potencia de un número dado el nº y su exponente.
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función (número)</param>
        /// <param name="b">Determina segundo parámetro (exponente)</param>
        /// <returns></returns>
        static int Elevado(int a, int b)
        {
            int resultado, contador;
            resultado = 1;

            for(contador = 1; contador <= b; contador++)
            {
                resultado = resultado * a;
            }
            return resultado;
        }

        /// <summary>
        /// Función que calcula el factorial de un número que el usuario escribe en consola.
        /// </summary>
        /// <param name="numero">Variable que determina el único parámetro de la función</param>
        /// <returns>Devuelve cálculo del factorial del nº escrito por el usuario</returns>
        static int Factorial(int numero)
        {
            int factorial, i;
            factorial = 1;

            for(i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        /// <summary>
        /// Función que lee tres nº's del teclado.
        /// </summary>
        /// <param name="x">Designa el primer parámetro</param>
        /// <param name="y">Designa el segundo parámetro</param>
        /// <param name="z">Designa el tercer parámetro</param>
        static void Lee3(out int x, out int y, out int z)
        {
            Console.WriteLine("Escribe tres nº's, por favor: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

        }

        /// <summary>
        /// Función que incrementa un nº que pasamos por parámetro.
        /// </summary>
        /// <param name="n">Determina el parámetro número</param>
        /// <returns>Devuelve el incremento de dicho nº</returns>
        static int Inc(int n)
        {
            n = n + 1;
            return n;
        }

        /// <summary>
        /// Función que decrementa un nº que pasamos por parámetro.
        /// </summary>
        /// <param name="n">Determina el parámetro de la función.</param>
        /// <returns>Devuelve nº decrementado</returns>
        static int Dec(int n)
        {
            n = n - 1;
            return n;
        }

        /// <summary>
        /// Función que calcula la resolución de una cámara tomando datos en megapíxeles.
        /// </summary>
        /// <param name="megapixel">Determina primer parámetro de la función (también variable
        /// para cálculo operación</param>
        /// <param name="x">Determina segundo parámetro de la función</param>
        /// <param name="y">Determina tercer parámetro</param>
        static void ResolucionCamara(double megapixel, out double x, out double y)
        {
            y = Math.Sqrt((megapixel * 1000000 * 9) / 16);
            x = (y * 16) / 9;
        }
        
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Menú FUNCIONES 2");
            Console.WriteLine("================");
            Console.WriteLine("Opciones: ");
            Console.WriteLine(" 1- AreaTriangulo");
            Console.WriteLine(" 2- PulgadasAcentimetros");
            Console.WriteLine(" 3- CentimetrosApulgadas");
            Console.WriteLine(" 4- NotaEnTexto");
            Console.WriteLine(" 5- LeeNatural");
            Console.WriteLine(" 6- LeeNumero");
            Console.WriteLine(" 7- Elevado");
            Console.WriteLine(" 8- Factorial");
            Console.WriteLine(" 9- Lee3");
            Console.WriteLine(" 10- Inc");
            Console.WriteLine(" 11- Dec");
            Console.WriteLine(" 12- ResolucionCamara");

            Console.WriteLine("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        int b, h;
                        Console.WriteLine("Calcularemos el área de un triángulo: ");
                        Console.Write("Escriba la base del triángulo: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba altura del triángulo: ");
                        h = int.Parse(Console.ReadLine());
                        Console.WriteLine("El área del es: " + AreaTriangulo(b,h));
                    }
                    break;
                case 2:
                    {
                        double pulgadas;
                        Console.Write("Escribe las pulgadas que quieres convertir a centímetros: ");
                        pulgadas = double.Parse(Console.ReadLine());
                        Console.Write(pulgadas + " pulgadas son " + PulgadasAcentimetros(pulgadas) + " centímetros.");
                    }
                    break;
                case 3:
                    {
                        double conversion;
                        Console.WriteLine("Escribe los centímetros que quieres convertir en pulgadas: ");
                        conversion = double.Parse(Console.ReadLine());
                        Console.WriteLine(conversion + " centímetros son " + CentimetrosApulgadas(conversion) + " pulgadas.");
                    }
                    break;
                case 4:
                    {
                        double nota;
                        Console.Write("Escribe la nota del alumno: ");
                        nota = double.Parse(Console.ReadLine());
                        Console.WriteLine(NotaEnTexto(nota));
                    }
                    break;
                case 5:
                    {
                        int numero;
                        numero = LeeNatural();
                        Console.WriteLine("Usted ha escrito el nº " + numero);
                        
                    }
                    break;
                case 6:
                    {
                        int a, b, n;

                        Console.WriteLine("Escriba un nº: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba otro nº: ");
                        b = int.Parse(Console.ReadLine());

                        n = LeeNumero(a, b);
                        Console.WriteLine("El número leído es " + n);
                        Console.ReadKey();

                    }
                    break;
                case 7:
                    {
                        int numero, exponente;
                        Console.Write("Escriba el nº: ");
                        numero = int.Parse(Console.ReadLine());
                        Console.Write("Escriba el exponente: ");
                        exponente = int.Parse(Console.ReadLine());
                        Console.WriteLine(numero + " elevado a " + exponente + " es: " + Elevado(numero, exponente));
                    }
                    break;
                case 8:
                    {
                        int n;
                        Console.Write("Escribe un nº para calcular su factorial: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial de " + n + " es " + Factorial(n));
                    }
                    break;
                case 9:
                    {
                        int a, b, c;

                        Lee3(out a, out b, out c);
                        Console.WriteLine("");
                        Console.WriteLine("Los nº's escritos son : " + a + ", " + b + ", " + c);
                    }
                    break;
                case 10:
                    {
                        int num;
                        Console.WriteLine("Escriba un número para incrementarlo: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine(num + " incrementado es igual a: " + Inc(num));
                    }
                    break;
                case 11:
                    {
                        int n;
                        Console.WriteLine("Escribe un nº para decrementarlo: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine(n + " decrementado es igual a: " + Dec(n));
                    }
                    break;
                case 12:
                    {
                        double x, y, megapixeles;
                        Console.WriteLine("Dame los megapíxeles de tu cámara para decirte su resolución: ");
                        megapixeles = double.Parse(Console.ReadLine());

                        ResolucionCamara(megapixeles, out x, out y);
                        Console.WriteLine("La resolución es " + x + " x " + y);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
