using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        /// <summary>
        /// Función “EscribeArray5” a la que le pasamos un array de tipo entero de 
        /// cinco elementos y lo escribe por pantalla de la siguiente forma: [23, 43, 1, -3, 6]
        /// </summary>
        /// <param name="a">Determina el nombre del parámetro de la función y nombra el array del ejercicio</param>
        static void EscribeArray5(int[] a)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < 4; i++)
            {
                Console.Write(a[i]);
                Console.Write(",");
            }
            Console.Write(a[4]);
            Console.Write("]");
        }

        /// <summary>
        /// Función que muestra los nº's enteros que puede leer un array dependiendo del tamaño.
        /// </summary>
        /// <param name="a">Determina parámetro de la función</param>
        static void EscribeArray(int[] a)
        {
            int i;
            Console.Write("[");
            for(i = 0; i < a.Length-1; i++)
            {
                Console.Write(a[i]);
                Console.Write(", ");
            }
            Console.Write(a[a.Length-1]);
            Console.Write("]");
        }

        static void EscribeArrayBool(bool[] a)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i]);
                Console.Write(", ");
            }
            Console.Write(a[a.Length - 1]);
            Console.Write("]");
        }

        static void EscribeDouble(double[] a)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i]);
                Console.Write(", ");
            }
            Console.Write(a[a.Length - 1]);
            Console.Write("]");
        }

        /// <summary>
        /// Función que lee 5 elementos y los muestra en consola con el siguiente formato [0, 1, 2, 3, 4, 5]
        /// </summary>
        /// <param name="a">Determina parámetro y apunta al array</param>
        static void LeeArray5(int[] a)
        {
            int i;
            Console.WriteLine(")))))Escribe los 5 valores del array((((((");
            Console.WriteLine();
            for(i = 0; i < 5; i++)
            {
                Console.Write("Escribe valor: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            
        }

        /// <summary>
        /// Función que lee un array de cualquier tamaño. Devuelve tamaño de la función y lectura de sus datos.
        /// </summary>
        /// <param name="a">Determina el parámetro de la función y denomina el array</param>
        static void LeeArray(int[] a)
        {
            int i;
            Console.WriteLine(")))Escribe los valores para el array(((");
            for(i = 0; i < a.Length; i++)
            {
                Console.Write("Escribe valor: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            
        }

        /// <summary>
        /// Función que cambia a valor 0 los 5 elementos del array.
        /// </summary>
        /// <param name="a">Variable que denomina el array y parámetro de la función</param>
        static int PonCero5(int[] a)
        {
            int i;
            for(i = 0; i < 5; i++)
            {
                a[i] = 0;               
            }
            return i;
        }

        /// <summary>
        /// Función que cambia a valor 0 los elementos que sean de un array.
        /// </summary>
        /// <param name="a">Variable que denomina el array y parámetro de la función</param>
        static int PonCero(int[] a)
        {
            int i;
            for(i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
            return i;
        }

        /// <summary>
        /// Función que suma los valores de cinco arrays que pasa por parámetros el usuario.
        /// </summary>
        /// <param name="a">Denomina el array de la función.</param>
        static int SumaArray5(int[] a)
        {
            int i, suma;
            suma = 0;
            for(i = 0; i < 5; i++)
            {
                suma = suma + a[i];
                
            }
            return suma;

        }

        /// <summary>
        /// Función que suma los valores un array de cualquier tamaño.
        /// </summary>
        /// <param name="a">Denomina el array y el parámetro de la función</param>
        static int SumaArray(int[] a)
        {
            int i, suma;
            suma = 0;
            for(i = 0; i < a.Length; i++)
            {
                suma = suma + a[i];
            }
            return suma; 
        }

        /// <summary>
        /// Función que calcula la media de los 5 valores de un array.
        /// </summary>
        /// <param name="a">Denomina el array y el parámetro de la función</param>
        static int MediaArray5(int[] a)
        {
            int i, media, suma;
            suma = 0;
            media = 0;
            for(i = 0; i < 5; i++)
            {
                suma = suma + a[i]; 
            }
            media = suma / 5;
            return media;
        }

        /// <summary>
        /// Función que calcula la media de los valores del un array de cualquier tamaño.
        /// </summary>
        /// <param name="a">Denomina el array y el parámetro de la función</param>
        static int MediaArray(int[] a)
        {
            int i, media, suma;
            suma = 0;
            media = 0;
            for(i = 0; i < a.Length; i++)
            {
                suma = suma + a[i];
            }
            media = suma / a.Length;
            return media;
        }

        /// <summary>
        /// Función que muestra nº's en forma ordenada dependiendo del tamaño.
        /// </summary>
        /// <param name="a">Determina el array y el parámetro de la función</param>
        static void RellenaEnOrden(int[] a)
        {
            int i, ordena;
            ordena = 1;
            for(i = 0; i < a.Length; i++)
            {
                a[i] = ordena;
                ordena = ordena + 1;
            }
            
        }

        /// <summary>
        /// Función que ordena en forma decreciente los nº's de un array según su tamaño.
        /// </summary>
        /// <param name="a">Determina el array y el parámetro de la función</param>
        static void RellenaEnOrdenDesc(int[] a)
        {
            int i, ordena;
            ordena = a.Length;
            for(i = 0; i < a.Length; i++)
            {
                a[i] = ordena;
                ordena = ordena - 1;
            }
        }

        /// <summary>
        /// Función que muestra nº's aleatorios del 1 al 10,
        /// </summary>
        /// <param name="a">Determina el array y el parámetro de la función</param>
        static void RellenaAleatorio(int[] a)
        {
            int i;
            Random numeroAleatorio = new Random();
            for(i = 0; i < a.Length; i++)
            {
                a[i] = numeroAleatorio.Next(1, 10);
            }
        }

        /// <summary>
        /// Función que devuelve verdadero o falso si los elementos del array que pasen por parámetros 
        /// están ordenados en modo ascendente.
        /// </summary>
        /// <param name="a">Determina el array y el parámetro de la función</param>
        /// <returns>Retorna valor booleano</returns>
        static bool EstaOrdenado(int[] a)
        {
            int i;
            bool ordenado = true;
            for(i = 0; i < a.Length-1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    ordenado = false;
                }

            }
            return ordenado;
        }

        /// <summary>
        /// Función que cuenta los impares de un array que se pasa con valores.
        /// </summary>
        /// <param name="a">Determina el array y el parámetro de la función</param>
        /// <returns>Devuelve nº de impares encontrados</returns>
        static int NumerosImpares(int[] a)
        {
            int i, impares;
            impares = 0;
            for(i = 0; i < a.Length; i++)
            {
                if(a[i] %2 != 0)
                {
                    impares = impares + 1;
                }
                             
            }
            return impares;
        }

        /// <summary>
        /// Función que muestra el nº menor del array.
        /// </summary>
        /// <param name="a">Determina el array y el parámetro de la función</param>
        /// <returns>Devuelve el nº menor</returns>
        static int MinArray(int[] a)
        {
            int i, min;
            min = a[0];
            for (i = 0; i < a.Length; i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }

            }
            return min;
            
        }

        /// <summary>
        /// Función que devuelve el valor más alto del array.
        /// </summary>
        /// <param name="a">Determina el array y el parámetro de la función</param>
        /// <returns>Devuelve valor más alto del array</returns>
        static int MaxArray(int[] a)
        {
            int i, max;
            max = a[0];
            for(i = 0; i < a.Length; i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }

            }
            return max;
        }

        /// <summary>
        /// Función que suma nº's de aprobados de una serie de notas pasadas por un array.
        /// </summary>
        /// <param name="a">Determina el parámetro de la función</param>
        /// <returns>Devuelve suma de notas aprobados</returns>
        static int NumeroAprobados(int[] a)
        {
            int i, aprobados;
            aprobados = 0;
            for(i = 0; i < a.Length; i++)
            {
                if(a[i] >= 5 && a[i] <= 10)
                {
                    aprobados = aprobados + 1;
                }
            }
            return aprobados;
        }

        /// <summary>
        /// Función que compara nº's en un array mediante un límite. 
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función</param>
        /// <param name="limite">Determina segundo parámetro de la función</param>
        /// <returns>Devuelve contador de nº's iguales o mayores que el límite</returns>
        static int PorEncimaDe(int[] a, int limite)
        {
            int i, contador;
            contador = 0;
            for(i = 0; i < a.Length; i++)
            {
                if(a[i] >= limite)
                {
                    contador = contador + 1;
                }
                
            }
            return contador;
        }

        /// <summary>
        /// Función que suma cantidad de ceros que contienen los elementos del array
        /// </summary>
        /// <param name="a">Determina el parámetro de la función y array de valores que devuelve la misma</param>
        /// <returns>Devuelve contador de ceros</returns>
        static int CuantosCeros(int[] a)
        {
            int i, contadorCeros;
            contadorCeros = 0;
            for( i = 0; i < a.Length; i++)
            {
                if(a[i] == 0)
                {
                    contadorCeros = contadorCeros + 1;
                }
            }
            return contadorCeros;
        }

        /// <summary>
        /// Función que copia contenido de un array en otro
        /// </summary>
        /// <param name="a">Primero parámetro de la función relacionado con el primer array</param>
        /// <param name="b">Segundo parámetro de la función relacionado con el segundo array</param>
        static void CopiaArray(int[] a, int[] b)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
        }

        /// <summary>
        /// Función que copia de forma invertida el contenido de valores de un array a otro
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y el primer array</param>
        /// <param name="b">Determina segundo parámetro de la función y el segundo array</param>
        static void CopiaArrayInvertido(int[] a, int[] b)
        {
            int i;
            int u = a.Length - 1;
            for (i = 0; i < a.Length; i++)
            {
                b[i] = a[u];
                u--;
            }
        }

        /// <summary>
        /// Función que suma contendido de dos arrays y alamacena el resultado en un tercero.
        /// </summary>
        /// <param name="a1">Determina primer parámetro de la función y el primer array</param>
        /// <param name="a2">Determina segundo parámetro de la función y el segundo array</param>
        /// <param name="a3">Determina tercer parámetro de la función y el tercer array</param>
        static void SumaArrays(int[] a1, int[] a2, int[] a3)
        {
            int i;
            if( a1.Length == a2.Length && a2.Length == a3.Length)
            {
                for(i = 0; i < a1.Length; i++)
                {
                    a3[i] = a1[i] + a2[i];
                }
                
            }
            else
            {
                throw new Exception("Error");
            }
        }

        /// <summary>
        /// Función que resta dos arrays y almacena resultado en un tercer array
        /// </summary>
        /// <param name="a1">Determina primer parámetro de la función y primer array del ejercicio</param>
        /// <param name="a2">Determina segundo parámetro de la función y segundo array del ejercicio</param>
        /// <param name="resultado">Determina tercer array el cual se usa para ubicar resultado de la resta</param>
        static void RestaArrays(int[] a1, int[] a2, int[] resultado)
        {
            int i;
            if(a1.Length == a2.Length && a2.Length == resultado.Length)
            {
                for(i = 0; i < a1.Length; i++)
                {
                    resultado[i] = a1[i] - a2[1];
                }
            }
        }

        /// <summary>
        /// Función que multiplica dos arrays y alamacena resultado en un tercer array vacío.
        /// </summary>
        /// <param name="a1">Determina parámetro de la primera función y primer array</param>
        /// <param name="a2">Determina parámetro de la segunda función y segundo array</param>
        /// <param name="resultado">Determina tercer parámetro el cual contiene resultado de la multiplicación</param>
        static void MultiplicarArrays(int[] a1, int[] a2, int[] resultado)
        {
            int i;
            if(a1.Length == a2.Length && a2.Length == resultado.Length)
            {
                for(i = 0; i < a1.Length; i++)
                {
                    resultado[i] = a1[i] * a2[i];
                }
            }
        }

        /// <summary>
        /// Función que divide dos arrays y almacena resultado en un tercero.
        /// </summary>
        /// <param name="a1">Determina primer parámetro de la función y primer array</param>
        /// <param name="a2">Determina segundo parámetro de la función y segundo array</param>
        /// <param name="resultado">Determina tercer parámetro de la función y tercer array el cual 
        /// contiene el resutado de la división</param>
        static void DivideArrays(int[] a1, int[] a2, int[] resultado)
        {
            int i;
            if(a1.Length == a2.Length && a2.Length == resultado.Length)
            {
                for(i = 0; i < a1.Length; i++)
                {
                    resultado[i] = a1[i] / a2[i];
                }
            }
        }

        /// <summary>
        /// Función que invierte los valores de un array.
        /// </summary>
        /// <param name="a">Determina el parámetro del array</param>
        static void InvierteArrays(int[] a)
        {
            int i;
            int primeraPosicionGuardada;
            int contador = a.Length-1;                   
            for(i = 0; i < a.Length/2; i++,contador--)
            {
                primeraPosicionGuardada = a[i];
                a[i] = a[contador];
                a[contador] = primeraPosicionGuardada;
            }
        }

        /// <summary>
        /// Función que compara dos arrays y devuelve true o false según su similitud de tamaño y contenidos
        /// </summary>
        /// <param name="a">Determina el primer parámetro de la función y el primer array</param>
        /// <param name="b"></param>
        /// <returns></returns>
        static bool ComparaArrays(int[] a, int[] b)
        {
            bool compara = false;
            int i;
            int contador = 0;
            if(a.Length == b.Length)
            {
                for(i = 0; i < a.Length; i++)
                {
                    if(a[i] == b[i])
                    {
                        contador = contador + 1;
                    }
                }
                if(contador == a.Length)
                {
                    compara = true;
                }
                else
                {
                    compara = false;
                }
            }
            return compara;
            
        }

        /// <summary>
        /// Función que identifica notas de alumnos. Devuelve verdadero o falso según estén o no aprobados.
        /// </summary>
        /// <param name="notas">Determina primer parámetro de la función y declaración de primer array</param>
        /// <param name="aprobados">Determina segundo parámetro de la función y declaración de segundo array</param>
        static void PonNotaArrays(double[] notas, bool[] aprobados)
        {
            int i;
           
            for(i = 0; i < notas.Length; i++)
            {
                if(notas[i] >= 5 && notas[i] <= 10)
                {
                    aprobados[i] = true;
                }
                else
                {
                    aprobados[i] = false;
                }
            }
        }

        /// <summary>
        /// Función que concatena dos arrays del tamaño que sea. Usa un tercer array para ubicar contenido
        /// del resultado de la concatenación.
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y primer array</param>
        /// <param name="b">Determina segundo parámetro de la función y segundo array</param>
        /// <param name="resultado">Determina tercer parámetro de la función y array que almacena
        /// el resultado de la concatenación de los dos primeros arrays</param>
        static void ConcatenaArrays55(int[] a, int[] b, int[] resultado)
        {
            int i;
            for(i = 0; i < a.Length; i++)
            {
                resultado[i] = a[i];
            }
            for(i = 0; i < b.Length; i++)
            {
                resultado[i + a.Length] = b[i];
            }

            
        }

        /// <summary>
        /// Función que concatena dos arrays de cualquier tamaño. Almacena concatenado en un tercer array.
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y primer array del ejercicio</param>
        /// <param name="b">Determina segundo parámetro de la función y segundo array</param>
        /// <param name="resultado">Determina terecer parámetro que pide la función y array contenedor
        /// del concatenado de los dos primeros</param>
        static void ConcatenaArrays(int[] a, int[] b, int[] resultado)
        {
            int i;
            for(i = 0; i < a.Length; i++)
            {
                resultado[i] = a[i];
            }
            for(i = 0; i < b.Length; i++)
            {
                resultado[i + a.Length] = b[i];
            }
        }

        /// <summary>
        /// Función que reconoce valor concreto en un array. Si el valor se encuentra devuelve verdadero,
        /// por el contrario devuelve falso.
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y único array del ejercicio</param>
        /// <param name="valor">Determina segundo parámetro de la función y valor del entero a examinar</param>
        /// <returns>Devuelve true o false según la existencia valor entero en concreto</returns>
        static bool Contiene(int[] a, int valor)
        {
            bool loTiene = false;
            int i;
            for(i = 0; i < a.Length; i++)
            {
                if(a[i] == valor)
                {
                    loTiene = true;
                }                
            }
            return loTiene;
        }

        /// <summary>
        /// Función que concatena dos arrays devolviendo resultado (usadmos int[])
        /// </summary>
        /// <param name="a">Determina el primer parámetro de la función y el primer array</param>
        /// <param name="b">Determina el segundo parámetro de la función y el segundo array</param>
        /// <returns>Devuelve resultado de la concatenación de ambos arrays</returns>
        static int[] ConcatenaArraysPro(int[] a, int[] b)
        {
            int[] concatena = new int[a.Length + b.Length];
            int i;
            int j = 0;
            for (i = 0; i < a.Length; i++)
            {
                concatena[j] = a[i];
                j++;
            }
            for (i = 0; i < b.Length; i++)
            {
                concatena[j] = b[i];
                j++;
            }
            return concatena;
        }

        static int[] ConcatenaArraysPro2(int[]a,int[]b)
        {
            int[] concatena = new int[a.Length + b.Length];
            ConcatenaArrays(a, b, concatena);
            return concatena;
        }

        /// <summary>
        /// Función que copia contenido de un array en otro
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y único array</param>
        /// <returns>Devuelve copia del array</returns>
        static int[] CopiaArrayPro(int[] a)
        {
            int i;
            int[] b = new int[a.Length];
            for(i = 0; i < a.Length; i++)
            {
                b[i] = a[i];

            }
            return b;

        }

        /// <summary>
        /// Función que inserta, un valor cualquiera en una posición cualquiera, en un array
        /// </summary>
        /// <param name="a">Determina el primer parámetro de la función y el array</param>
        /// <param name="valor">Determina el segundo parámetro de la función y corresponde al valor</param>
        /// <param name="posicion">Determina el tercer parámetro de la función y corresponde a la posición del 
        /// nuevo valor insertado</param>
        /// <returns>Devuelve array modificado con nuevo valor insertado</returns>
        static int[] InsertaEnArray(ref int[] a, int valor, int posicion) 
        {
            Array.Resize(ref a, a.Length+1);
            int i;

            for( i = a.Length - 1; i > posicion; i--)
            {
                a[i] = a[i - 1];
            }

            a[posicion] = valor;
            return a;
            
        }

        /// <summary>
        /// Función que borra elemento del array según su posición
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y corresponde con el array</param>
        /// <param name="posicion">Determina segundo parámetro y corresponde con la posición del elemento</param>
        /// <returns>Devuelve array después de su redimensión</returns>
        static int[] BorraDeArray(ref int[] a, int posicion)
        {
            int i;
            for( i = posicion; i < a.Length-1; i++)
            {
                a[i] = a[i + 1];
            }
            Array.Resize(ref a, a.Length - 1);
            return a;
        }

        /// <summary>
        /// Función que elimina elemento del array de valor concreto. Pero si el valor se repite entre
        /// los elementos solo se eliminará el primero de ellos.
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y el array que se pasa por referencia</param>
        /// <param name="valor">Determina segundo parámetro de la función y corresponde con el valor del entero</param>
        static void Elimina1ElementoArray(ref int[] a, int valor)
        {
            int i;
            for(i = 0; i < a.Length; i++)
            {
                if(a[i] == valor)
                {
                    BorraDeArray(ref a, i);
                    i = a.Length;
                }
            }           
            
        }

        /// <summary>
        /// Función que elimina elemento del array de valor concreto. En este caso elimina todos los valores iguales que
        /// correspondan con el elemento elegido, independientemente de la posición en la que se encuentre.
        /// </summary>
        /// <param name="a">Determina primer parámetro y corresponde al array que se pasa por referencia</param>
        /// <param name="valor">Determina segundo parámetro y corresponde con el valor del entero</param>
        static void EliminaElementosArray(ref int[] a, int valor)
        {
            int i; 
            for(i = 0; i < a.Length; i++)
            {
                if(a[i] == valor)
                {
                    BorraDeArray(ref a, i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Función que inserta array desde una posición concreta del array
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y corresponde al primer array</param>
        /// <param name="b">Determina segundo parámetro de la función y corresponde al segundo array</param>
        /// <param name="posicion">Determina tercer parámetro de la función y corresponde al valor de la posición</param>
        static void InsertaArrayEnArray(ref int[] a, int[] b, int posicion)
        {
            int i; 
            for(i = 0; i < b.Length; i++)
            {
                InsertaEnArray(ref a, b[i], posicion);
                posicion++;
            }
        }

        /// <summary>
        /// Función que copia valores de array desde dos puntos de cota. Te copia los valores desde el inico al final
        /// de la cota
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función y corresponde al array</param>
        /// <param name="inicio">Determina segundo parámetro y corresponde al inicio de la cota</param>
        /// <param name="fin">Determina tercer parámetro y corresponde al final de la cota</param>
        /// <returns>Devuelve copia de los elementos de la cota generada en el array</returns>
        static int[] SubArray(int[] a, int inicio, int fin)
        {
            int j, i;
         
            int cota = fin - inicio + 1;
            int[] b = new int[cota];

            i = 0;
            for (j = inicio; j <= fin; j++)
            {
                b[i] = a[j];
                i++;
            }
            return b;
        }

        static void RecortaArray(ref int[] a, int inicio, int fin)
        {
            //a = SubArray(a, inicio, fin); // SOLUCION DE LUIS(C)
            int i;
            for(i = a.Length; i > fin+1; i--)
            {
                BorraDeArray(ref a, i);               
            }
            int j;
            for(j = inicio -1; j >= 0; j--)
            {
                BorraDeArray(ref a, j);
            }
        }

        /// <summary>
        /// Inserta un elemento al final de un array.
        /// </summary>
        /// <param name="a">Primer parámetro de la función</param>
        /// <param name="b">Segundo parámetro de la función</param>
        static void InsertaAlFinalArray(ref int[] a, int b)
        {
            Array.Resize(ref a, a.Length + 1);

            a[a.Length - 1] = b;
        }
        /// <summary>
        /// Devuelve la posición donde se encuentra el elemento más pequeño del array.
        /// </summary>
        /// <param name="a">Único parámetro de la función, y array de la misma</param>
        /// <returns>Devuelve posición del valor más pequeño</returns>
        static int PosMinArray(int[] a)
        {
            int i, posicion = 0, minimo = a[0];

            for (i = 1; i < a.Length; i++)
            {
                if (a[i] < minimo)
                {
                    posicion = i;
                    minimo = a[i];
                }
            }
            return posicion;
        }
        /// <summary>
        ///  Algoritmo que realiza la ordenación de un array.
        /// </summary>
        /// <param name="array">Parámetro de la función y array de la misma</param>
        static void OrdenaSeleccion(int[] array)
        {
            int[] b = { };
            int pos, min;
            int[] a = CopiaArrayPro(array);

            while (a.Length > 0)
            {
                pos = PosMinArray(a);
                min = a[pos];
                InsertaAlFinalArray(ref b, min);
                BorraDeArray(ref a, pos);
            }

            CopiaArray(b, array);
        }

        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("MENÚ DE ARRAYS");
            Console.WriteLine("==============");
            Console.WriteLine(" 1- EscribeArray5");
            Console.WriteLine(" 2- EscribeArray");
            Console.WriteLine(" 3- LeeArray5");
            Console.WriteLine(" 4- LeeArray");
            Console.WriteLine(" 5- PonCeros5");
            Console.WriteLine(" 6- PonCero");
            Console.WriteLine(" 7- SumaArray5");
            Console.WriteLine(" 8- SumaArray");
            Console.WriteLine(" 9- MediaArray5");
            Console.WriteLine(" 10- MediaArray");
            Console.WriteLine("11- RellenaEnOrden");
            Console.WriteLine("12- RellenaEnOrdenDesc");
            Console.WriteLine("13- RellenaAleatorio");
            Console.WriteLine("14- EstaOrdenado");
            Console.WriteLine("15- NumerosImpares");
            Console.WriteLine("16- MinArray");
            Console.WriteLine("17- MaxArray");
            Console.WriteLine("18- NumeroAprobados");
            Console.WriteLine("19- PorEncimaDe");
            Console.WriteLine("20- CuantosCeros");
            Console.WriteLine("21- CopiaArray");
            Console.WriteLine("22- CopiaArrayInvertido");
            Console.WriteLine("23- SumaArrays"); 
            Console.WriteLine("24- RestaArrays"); //24 del pdf
            Console.WriteLine("25- MultiplicaArrays"); //24 del pdf
            Console.WriteLine("26- DivideArrays"); //24 del pdf
            Console.WriteLine("27- InvierteArrays"); //25 del pdf
            Console.WriteLine("28- ComparaArrays"); //26 del pdf
            Console.WriteLine("29- PonNotaArrays"); //27 del pdf
            Console.WriteLine("30- ConcatenaArrays55"); //28 del pdf
            Console.WriteLine("31- ConcatenaArrays"); //29 del pdf
            Console.WriteLine("32- Contiene"); //30 del pdf
            Console.WriteLine("33- ConcatenaArraysPro"); //31 del pdf
            Console.WriteLine("34- CopiaArrayPro"); //32 del pdf
            Console.WriteLine("35- InsertaEnArray"); //33 del pdf
            Console.WriteLine("36- BorraDeArray"); //34 del pdf
            Console.WriteLine("37- Elimina1ElementoArray"); //35 del pdf
            Console.WriteLine("38- EliminaElementoArray"); //36 del pdf
            Console.WriteLine("39- InsertaArrayEnArray"); //37 del pdf
            Console.WriteLine("40- SubArray"); //38 del pdf
            Console.WriteLine("41- RecortaArray"); //39 del pdf
            Console.WriteLine("42- OrdenaSeleccion"); //40 del pdf
            Console.WriteLine("");
            Console.Write(":< ELIGE UNA OPCIÓN >: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        int[] array = { 23, 43, 1, -3, 6 };
                        EscribeArray5(array);
                    }
                    break;
                case 2:
                    {
                        int[] a = { 10, 20, 30 };
                        EscribeArray(a);
                    }
                    break;
                case 3:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);
                        Console.WriteLine();
                        Console.WriteLine("El array leido es: ");                       
                        EscribeArray5(a);
                    }
                    break;
                case 4:
                    {
                        Console.Write("Escribe el tamaño del array: ");
                        
                        int t = int.Parse(Console.ReadLine());
                        int[] a = new int[t];
                        LeeArray(a);
                        Console.WriteLine();
                        EscribeArray(a);
                    }
                    break;
                case 5:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);
                        PonCero5(a);
                        EscribeArray5(a);                         
                    }
                    break;
                case 6:
                    {                       
                        Console.Write("Escribe el tamaño del array: ");
                        int t = int.Parse(Console.ReadLine());
                        int[] a = new int[t];
                        LeeArray(a);
                        PonCero(a);
                        EscribeArray(a);
                    }
                    break;
                case 7:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);                        
                        Console.WriteLine("El resultado de la suma es: " + SumaArray5(a));
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Escribe el tamaño del array");
                        int t = int.Parse(Console.ReadLine());

                        int[] a = new int[t];
                        LeeArray(a);
                        Console.WriteLine("El resultado del la suma es " + SumaArray(a));
                    }
                    break;
                case 9:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);                        
                        Console.WriteLine("La media de los 5 valores es: " + MediaArray5(a));
                    }
                    break;
                case 10:
                    {
                        Console.Write("Escribe el tamaño deseado para el array: ");
                        int t = int.Parse(Console.ReadLine());
                        int[] a = new int[t];
                        LeeArray(a);
                        Console.WriteLine("La media de los valores del array es: " + MediaArray(a));
                    }
                    break;
                case 11:
                    {
                        Console.Write("Escribe el tamño del array:");
                        Console.WriteLine();
                        int t = int.Parse(Console.ReadLine());
                        int[] a = new int[t];
                        EscribeArray(a);
                        RellenaEnOrden(a);
                        Console.WriteLine();
                        EscribeArray(a);
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Escribe el tamaño del array: ");
                        int t = int.Parse(Console.ReadLine());
                        int[] a = new int[t];
                        EscribeArray(a);
                        RellenaEnOrdenDesc(a);
                        Console.WriteLine();
                        EscribeArray(a);
                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("Escribe tamaño para array:");
                        int t = int.Parse(Console.ReadLine());
                        int[] a = new int[t];
                        EscribeArray(a);
                        RellenaAleatorio(a);
                        Console.WriteLine();
                        EscribeArray(a);
                    }
                    break;
                case 14:
                    {

                        int[] a = { 1,2,3};
                        EscribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine(EstaOrdenado(a));
                    }
                    break;
                case 15:
                    {
                        int[] a = { 5, 2, 14, 12, 9 };
                        EscribeArray(a);
                        Console.WriteLine(NumerosImpares(a));
                    }
                    break;
                case 16:
                    {
                        int[] a = { 2, 6, 7, 8, 9, 34 };
                        EscribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("El menor de los valores es: " + MinArray(a));
                    }
                    break;
                case 17:
                    {
                        int[] a = { 100, 250, 4, 2550 };
                        EscribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("El mayor de los valores es: " + MaxArray(a));
                    }
                    break;
                case 18:
                    {
                        int[] a = { 5, 9, 7, 4, 4 };
                        EscribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("Tenemos " + NumeroAprobados(a) + " aprobados");
                    }
                    break;
                case 19:
                    {
                        int limite = 30;
                        int[] a = { 30,30,30,65,100,79,4,2,9};
                        EscribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("Tenemos " + PorEncimaDe(a, limite) + " números que coinciden o superan al límite");
                    }
                    break;
                case 20:
                    {
                        int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 5, 8, 9, 40 };
                        EscribeArray(a);
                        Console.WriteLine();
                        Console.WriteLine("Tenemos " + CuantosCeros(a) + " ceros en nuestro array");
                    }
                    break;
                case 21:
                    {
                        //variables
                        int[] array1, array2;
                        array1 = new int[] { 1, 2, 3, 4 };
                        array2 = new int[array1.Length];
                        
                        CopiaArray(array1, array2);
                        EscribeArray(array2);
                    }
                    break;
                case 22:
                    {
                        int[] array1, array2;
                        array1 = new int[] { 5, 6, 7, 8, 9 };
                        array2 = new int[array1.Length];
                        CopiaArrayInvertido(array1, array2);
                        EscribeArray(array2);

                    }
                    break;
                case 23:
                    {
                        int[] a1 = { 1,2,3};
                        int[] a2 = { 8, 6, 8 };
                        int[] a3 = new int[a1.Length];
                        EscribeArray(a1);
                        Console.Write(" + ");
                        EscribeArray(a2);
                        Console.Write(" = ");
                        SumaArrays(a1, a2, a3);
                        EscribeArray(a3);
                    }
                    break;
                case 24:
                    {
                        int[] array1 = { 10,10,10};
                        int[] array2 = { 5,5,5};
                        int[] resultado = new int[array1.Length];
                        EscribeArray(array1);
                        Console.Write(" - ");
                        EscribeArray(array2);
                        Console.Write(" = ");
                        RestaArrays(array1, array2, resultado);
                        EscribeArray(resultado);
                    }
                    break;
                case 25:
                    {
                        int[] a1 = { 2,2,2};
                        int[] a2 = { 5,5,5};
                        int[] resultado = new int[a1.Length];
                        EscribeArray(a1);
                        Console.Write(" x ");
                        EscribeArray(a2);
                        Console.Write(" = ");
                        MultiplicarArrays(a1, a2, resultado);
                        EscribeArray(resultado);
                    }
                    break;
                case 26:
                    {
                        int[] a1 = { 120, 120, 120};
                        int[] a2 = { 3,3,3};
                        int[] resultado = new int[a1.Length];
                        EscribeArray(a1);
                        Console.Write(" / ");
                        EscribeArray(a2);
                        Console.Write(" = ");
                        DivideArrays(a1, a2, resultado);
                        EscribeArray(resultado);
                    }
                    break;
                case 27:
                    {
                        int[] a = { 1,2,3,8,4,5,6};                        
                        InvierteArrays(a);
                        EscribeArray(a);

                    }
                    break;
                case 28:
                    {
                        int[] a = { 2,3,4};
                        int[] b = { 2,3,4,7,8,9};
                        Console.WriteLine(ComparaArrays(a,b));
                    }
                    break;
                case 29:
                    {
                        double[] notas = { 10,2,8,9,7,4,3,5};
                        bool[] aprobados = new bool[notas.Length];
                        PonNotaArrays(notas, aprobados);
                        EscribeDouble(notas);
                        Console.WriteLine();
                        EscribeArrayBool(aprobados);
                       
                    }
                    break;
                case 30:
                    {
                        int[] a = new int[] { 1,2,3,4,5};
                        int[] b = new int[] { 6,7,8,9,10};
                        int[] resultado = new int[10];
                        EscribeArray(a);
                        Console.Write(" & ");
                        EscribeArray(b);
                        Console.Write(" = ");
                        ConcatenaArrays55(a, b, resultado);
                        EscribeArray(resultado);                                               
                    }
                    break;
                case 31:
                    {
                        int[] a = new int[] { 2,3,44,57,10,1,9,11,13};
                        int[] b = new int[] { 41,32,15};
                        int[] resultado = new int[a.Length + b.Length];
                        EscribeArray(a);
                        Console.Write(" & ");
                        EscribeArray(b);
                        Console.Write(" = ");
                        ConcatenaArrays(a, b, resultado);
                        EscribeArray(resultado);
                        
                    }
                    break;
                case 32:
                    {
                        int[] a = new int[] { 3,4,5,6,7,9};
                        int valor = 9;
                        Console.Write("El array ");
                        EscribeArray(a);
                        Console.Write(" en su búsqueda del valor " + valor + ", devuelve: " + Contiene(a, valor));
                        
                    }
                    break;
                case 33:
                    {
                        int[] a = new int[] { 15,15,15,7,7,7};
                        int[] b = new int[] { 92,92,92};
                        int[] concatena;
                        EscribeArray(a);
                        Console.Write(" & ");
                        EscribeArray(b);
                        Console.Write(" = ");
                        concatena = ConcatenaArraysPro(a, b);
                        EscribeArray(concatena);
                        //Console.Write(" = " + ConcatenaArraysPro(a, b));
                                                 
                    }
                    break;
                case 34:
                    {
                        int[] a = new int[] { 1,2,3};
                        int[] b = new int[a.Length];
                        b = CopiaArrayPro(a);
                        EscribeArray(a);
                        Console.WriteLine("");
                        Console.Write("<->");
                        Console.WriteLine("");
                        EscribeArray(b);

                        
                    }
                    break;
                case 35:
                    {
                        int[] array = new int[] { 1,2,3,4,5};
                        int valor, posicion;
                        Console.WriteLine("Qué valor quieres insertar ??");
                        valor = int.Parse(Console.ReadLine());
                        Console.WriteLine("En qué posición quieres insertar el valor ??");
                        posicion = int.Parse(Console.ReadLine());
                        InsertaEnArray(ref array, valor, posicion);
                        EscribeArray(array);
                                                
                    }
                    break;
                case 36:
                    {
                        int[] a = new int[] { 2,3,5,6,7,8,9};
                        int posicion;
                        EscribeArray(a);
                        Console.WriteLine("");
                        Console.Write("Qué posición desea eliminar del array ??: ");
                        posicion = int.Parse(Console.ReadLine());
                        BorraDeArray(ref a, posicion);
                        Console.WriteLine("");
                        EscribeArray(a);

                    }
                    break;
                case 37:
                    {
                        int[] a = new int[] { 2,3,4,4,5,6};
                        int valor;
                        EscribeArray(a);
                        Console.Write(" <<>> ");
                        Console.Write("Qué valor desea eliminar del array ??:  ");
                        valor = int.Parse(Console.ReadLine());

                        Elimina1ElementoArray(ref a, valor);
                        EscribeArray(a);
                    }
                    break;
                case 38:
                    {
                        int[] a = new int[] { 4, 5, 5, 5, 6 };                       
                        int valor;
                        EscribeArray(a);
                        Console.Write(" <<>> ");
                        Console.Write("Qué valor desea eliminar del array ??:  ");
                        valor = int.Parse(Console.ReadLine());

                        EliminaElementosArray(ref a, valor);
                        EscribeArray(a);
                    }
                    break;
                case 39:
                    {
                        int[] a = new int[] { 4, 5, 6 };
                        int[] b = new int[] { 1, 2, 3 };
                        int valor;

                        EscribeArray(a);
                        Console.Write(" <=> ");
                        EscribeArray(b);
                        Console.WriteLine("");
                        Console.Write("En qué posición quieres insertar el array??: ");
                        valor = int.Parse(Console.ReadLine());

                        InsertaArrayEnArray(ref a, b, valor);
                        EscribeArray(a);
                    }
                    break;
                case 40:
                    {
                        int[] array1 = new int[] { 3, 4, 5, 6, 7, 8, 9 };
                        int[] array2;
                        int inicio, fin;

                        Console.WriteLine("Escribe el valor del inicio");
                        inicio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el valor de fin");
                        fin = int.Parse(Console.ReadLine());

                        array2 = SubArray(array1, inicio, fin);
                        EscribeArray(array2);
                    }
                    break;
                case 41:
                    {
                        int[] a = new int[] { 1,2,3,22,33,44,4,5,6};
                        int inicio, fin;

                        Console.WriteLine("Escribe la posición del inicio de la cota");
                        inicio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe la posición del final de la cota");
                        fin = int.Parse(Console.ReadLine());

                        EscribeArray(a);
                        RecortaArray(ref a, inicio, fin);
                        Console.Write(" <==> ");
                        EscribeArray(a);
                    }
                    break;
                case 42:
                    {
                        int[] a = { 4, 7, 1, 2, 9, 8, 1 };
                        EscribeArray(a);
                        OrdenaSeleccion(a);
                        EscribeArray(a);
                    }
                    break;


                default: Console.WriteLine("Opción no válida"); break;
            }
            Console.ReadKey();
        }
    }
}

