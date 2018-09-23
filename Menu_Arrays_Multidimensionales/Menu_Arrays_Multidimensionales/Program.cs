using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Arrays_Multidimensionales
{
    class Program
    {
        /// <summary>
        /// Función que escribe array bidimensional
        /// </summary>
        /// <param name="a3">Determina el parámetro de la función y el array bidimensional de la misma</param>
        static void EscribeArray3x3(int[,] a3)
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (j = 0; j < 3; j++)
                {
                    Console.Write(a3[i, j] + " ");
                }
                Console.WriteLine("|");
            }

        }

        /// <summary>
        /// Función que rellena array bi de tamaño 3x3 con los número del 1 al 9.
        /// </summary>
        /// <param name="arr">Determina el parámetro de la función y el array de la misma</param>
        static void Rellena3x3(int[,] arr)
        {
            int i, j;
            int cont = 1;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr[i, j] = cont;
                    cont++;
                }
            }
        }

        /// <summary>
        /// Función que rellena un array bidimensional de 3x3 con números aleatorios.
        /// </summary>
        /// <param name="a">Determina el parámetro de la función y el array de la misma</param>
        static void RellenaAleatorio3x3(int[,] a)
        {
            Random rmd = new Random();
            int aleatorio;
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    aleatorio = rmd.Next(1, 10);
                    a[i, j] = aleatorio;
                }
            }
        }

        /// <summary>
        /// Función que suma contenido de un array multidimensional de tamaño 3x3
        /// </summary>
        /// <param name="a">Determina el parámetro de la función y el array de la misma</param>
        /// <returns>Resultado de la suma de la suma del contenido del array</returns>
        static int SumaArray3x3(int[,] a)
        {
            int suma = 0;
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    suma = suma + a[i, j];
                }
            }
            return suma;
        }

        /// <summary>
        /// Función que imprime por pantalla array multidimensional de cualquier tamaño.
        /// </summary>
        /// <param name="a">Parámetro de la función y array de la misma</param>
        static void EscribeArrayBi(int[,] a)
        {
            int i, j;
            Console.ForegroundColor = ConsoleColor.Gray;
            for (i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("| ");
                for (j = 0; j < a.GetLength(1); j++)
                {
                    switch (a[i, j])
                    {
                        case 1:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            break;
                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            break;
                        case 3:
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }
                            break;
                        case 4:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            break;
                    }
                    Console.Write(a[i, j] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine("|");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Función que rellena array multidimensional de números enteros y aleatorios.
        /// </summary>
        /// <param name="a">Parámetro de la función y array de la misma.</param>
        static void RellenaAleatorioBi(int[,] a)
        {
            Random rnd = new Random();
            int r;
            int i, j;

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    r = rnd.Next(1, 10);
                    a[i, j] = r;
                }
            }
        }

        /// <summary>
        /// Función que rellena array de cualquier tamaño de números en orden a partir del 1.
        /// </summary>
        /// <param name="a">Parámetro de la función y array de la misma.</param>
        static void RellenaEnOrdenBi(int[,] a)
        {
            int i, j;
            int valor = 1;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = valor;
                    valor++;
                }
            }
        }

        /// <summary>
        /// Función que suma los enteros de un array bidimensional
        /// </summary>
        /// <param name="a">Parámetro de la función y array bidimensional de enteros</param>
        /// <returns>Resultado de la suma de los elementos enteros del array</returns>
        static int SumaArrayBi(int[,] a)
        {
            int i, j;
            int suma = 0;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    suma = suma + a[i, j];
                }
            }
            return suma;
        }

        /// <summary>
        /// Función que suma dos arrays bidimensionales y muestra el resultado en un tercero.
        /// </summary>
        /// <param name="a">Primer parámetro de la función y primer array de enteros</param>
        /// <param name="b">Segundo parámetro de la función y segundo array de enteros</param>
        /// <returns>Devuelve array contenedor del resultado de la suma</returns>
        static int[,] Suma2ArrayBi(int[,] a, int[,] b)
        {
            int[,] resultado = new int[a.GetLength(0), a.GetLength(1)];
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    resultado[i, j] = a[i, j] + b[i, j];
                }
            }
            return resultado;
        }

        /// <summary>
        /// Función que copia contenido de un array multidimensional en otro array inicialmente vacío.
        /// </summary>
        /// <param name="a">Parámetro de la función y array de enteros</param>
        /// <param name="vacio">Segundo parámetro de la función. Contenedor de la copia del array</param>
        static void CopiaArrayBi(int[,] a, int[,] vacio)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    vacio[i, j] = a[i, j];
                }
            }
        }

        /// <summary>
        /// Función que devuelve copia de datos de un array bidimensional
        /// </summary>
        /// <param name="a">Parámetro de la función y array de enteros</param>
        /// <returns>Devuelve array copiado</returns>
        static int[,] CopiaArrayBiPro(int[,] a)
        {
            int[,] copia = new int[a.GetLength(0), a.GetLength(1)];
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    copia[i, j] = a[i, j];
                }
            }
            return copia;
        }

        /// <summary>
        /// Función que rellena tablero de ajedrez de la siguiente forma:
        /// - Marca con 0 las casillas negras
        /// - Marca con 1 las casillas blancas
        /// </summary>
        /// <param name="a">Parámetro de la función y array de la misma</param>
        static void RellenaArrayAjedrez(int[,] a)
        {
            int i, j;
            int numero = 1;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = numero;
                    if (numero == 0)
                    {
                        numero = 1;
                    }
                    else
                    {
                        numero = 0;
                    }
                }
                if (numero == 0)
                {
                    numero = 1;
                }
                else
                {
                    numero = 0;
                }
            }

        }

        /// <summary>
        /// Función que rellena array cuadrado de la siguiente forma:
        /// - Número 1 en diagonal principal
        /// - Número 2 en zona superior de la diagonal
        /// - Número 3 en zona inferior de la diagonal
        /// </summary>
        /// <param name="a">Parámetro de la función y array de la misma</param>
        static void RellenaDiagonal(int[,] a)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        a[i, j] = 2;
                    }
                    else
                    {
                        a[i, j] = 3;
                    }
                    if (j == i)
                    {
                        a[i, j] = 1;
                    }
                }
            }
        }

        /// <summary>
        /// Función  que te rellena un array cuadrado con el número ‘1’ en las 
        /// dos diagonales y el ‘2’ en el resto
        /// </summary>
        /// <param name="a">Parámetro de la función y array de la misma</param>
        static void RellenaX(int[,] a)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        if (i + j == a.GetLength(1) - 1)
                        {
                            a[i, j] = 1;
                        }
                        else
                        {
                            a[i, j] = 2;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Función que te rellena un array cuadrado de lado par (o 
        ///sea, 2x2, 4x4, 6x6, etc.) en cuatro cuadros.El cuadro superior izquierdo lo rellena con 
        ///‘1’, el superior derecho, con ‘2’, el inferior izquierdo con ‘3’ y el inferior derecho con 
        ///‘4’
        /// </summary>
        /// <param name="a"></param>
        static void RellenaCuadros(int[,] a)
        {
            int i, j;
            for(i = 0; i < a.GetLength(0)/2; i++)
            {
                for(j = 0; j < a.GetLength(1)/2; j++)
                {
                    a[i, j] = 1;
                }
            }
            for(i = 0; i < a.GetLength(0)/2; i++)
            {
                for(j = a.GetLength(1)/2; j < a.GetLength(1); j++)
                {
                    a[i, j] = 2;
                }
            }
            for(i = a.GetLength(0)/2; i < a.GetLength(0); i++)
            {
                for(j = 0; j < a.GetLength(1)/2; j++)
                {
                    a[i, j] = 3;
                }
            }
            for(i = a.GetLength(0)/2; i < a.GetLength(0); i++)
            {
                for(j = a.GetLength(1)/2; j < a.GetLength(1); j++)
                {
                    a[i, j] = 4;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("MENÚ DE ARRAYS MULTIDIMENSIONALES");
            Console.WriteLine("=================================");
            Console.WriteLine("[1] EscribeArray3x3");
            Console.WriteLine("[2] Rellena3x3");
            Console.WriteLine("[3] RellenaAleatorio3x3");
            Console.WriteLine("[4] SumaArray3x3");
            Console.WriteLine("[5] EscribeArrayBi");
            Console.WriteLine("[6] RellenaAleatorioBi");
            Console.WriteLine("[7] RellenaEnOrdenBi");
            Console.WriteLine("[8] SumaArrayBi");
            Console.WriteLine("[9] Suma2ArrayBi");
            Console.WriteLine("[10] CopiaArrayBi");
            Console.WriteLine("[11] CopiaArrayBiPro");
            Console.WriteLine("[12] RellenaArrayAjedrez");
            Console.WriteLine("[13] RellenaDiagonal");
            Console.WriteLine("[14] RellenaX");
            Console.WriteLine("[15] RellenaCuadros");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    {
                        int[,] a = new int[3, 3];
                        EscribeArray3x3(a);
                    }
                    break;
                case 2:
                    {
                        int[,] a = new int[3, 3];
                        Rellena3x3(a);
                        EscribeArray3x3(a);
                    }
                    break;
                case 3:
                    {
                        int[,] a = new int[3, 3];
                        RellenaAleatorio3x3(a);
                        EscribeArray3x3(a);
                    }
                    break;
                case 4:
                    {
                        int[,] a = { { 3, 3, 3 }, { 5, 5, 5 }, { 2, 2, 2 } };
                        int suma = SumaArray3x3(a);
                        Console.WriteLine(suma);
                    }
                    break;
                case 5:
                    {
                        int[,] a = { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 }, { 4, 4, 4 } };
                        EscribeArrayBi(a);
                    }
                    break;
                case 6:
                    {
                        int[,] a = new int[4, 4];
                        RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                    }
                    break;
                case 7:
                    {
                        int[,] a = new int[4, 4];
                        RellenaEnOrdenBi(a);
                        EscribeArrayBi(a);
                    }
                    break;
                case 8:
                    {
                        int[,] a = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 },
                            { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
                        int suma = SumaArrayBi(a);
                        Console.WriteLine(suma);
                    }
                    break;
                case 9:
                    {
                        int[,] a = { { 5, 5, 5 }, { 5, 5, 5 } };
                        int[,] b = { { 10, 10, 10 }, { 10, 10, 10 } };
                        int[,] suma = new int[a.GetLength(0), a.GetLength(1)];
                        suma = Suma2ArrayBi(a, b);
                        EscribeArrayBi(suma);
                    }
                    break;
                case 10:
                    {
                        int[,] a = { { 2, 2, 2 }, { 3, 3, 3 }, { 10, 10, 10 } };
                        int[,] b = new int[a.GetLength(0), a.GetLength(1)];
                        CopiaArrayBi(a, b);
                        EscribeArrayBi(b);
                    }
                    break;
                case 11:
                    {
                        int[,] a = { { 23,22,21},{20,19,18 },
                            {17,16,15 },{14,13,12 } };
                        int[,] resultado = CopiaArrayBiPro(a);
                        EscribeArrayBi(resultado);
                    }
                    break;
                case 12:
                    {
                        int[,] a = new int[8, 8];
                        RellenaArrayAjedrez(a);
                        EscribeArrayBi(a);
                    }
                    break;
                case 13:
                    {
                        int[,] a = new int[8, 8];
                        RellenaDiagonal(a);
                        EscribeArrayBi(a);
                    }
                    break;
                case 14:
                    {
                        int[,] a = new int[8, 8];
                        RellenaX(a);
                        EscribeArrayBi(a);

                    }
                    break;
                case 15:
                    {
                        int[,] a = new int[8, 8];
                        RellenaCuadros(a);
                        EscribeArrayBi(a);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}

