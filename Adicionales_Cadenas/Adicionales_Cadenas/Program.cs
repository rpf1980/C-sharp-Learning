using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Adicionales_Cadenas
{
    class Program
    {
        static void EscribeCadena(string cadena)
        {
            Console.Write("#{");
            int i;
            for(i = 0; i < cadena.Length; i++)
            {
                Console.Write(cadena[i]);
            }
            Console.Write("}#");
        }

        static bool Contiene(string cadena, char caracter)
        {
            int i;
            bool contieneC = false;
            for(i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == caracter)
                {
                    contieneC = true;
                }
            }
            return contieneC;
        }

        static string QuitaEspacios(string cadena)
        {
            int i;
            for (i = 0; i < cadena.Length; i++)
            {
                cadena = cadena.Replace(" ", "");
            }
            return cadena;
        }

        static string PrimeraMayusculaDeFrase(string cadena)
        {
            string c2 = "";
            bool ponEnMayusculaLaSiguiente = true;
            int i;
            for (i = 0; i < cadena.Length; i++)
            {
                if (char.IsLetter(cadena[i]) && ponEnMayusculaLaSiguiente == true)
                {
                    c2 = c2 + char.ToUpper(cadena[i]);
                    ponEnMayusculaLaSiguiente = false;
                }
                else
                {
                    if(cadena[i] == '.')
                    {
                        c2 = c2 + cadena[i];
                        ponEnMayusculaLaSiguiente = true;
                    }
                    else
                    {
                        c2 = c2 + cadena[i];
                    }
                }
            }
            return c2;
        }

        static string MayusculasPrimera(string cadena)
        {
            string cadena2 = "";
            int i;
            cadena2 = cadena2 + char.ToUpper(cadena[0]);

            for (i = 1; i < cadena.Length; i++)
            {
                if (cadena[i - 1] == ' ')
                {
                    cadena2 = cadena2 + char.ToUpper(cadena[i]);
                }
                else
                {
                    cadena2 = cadena2 + cadena[i];
                }
            }
            return cadena2;
        }

        static void EscribeArray(int[] a)
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

        static void EscribeNombres(string cadena)
        {
            string[] c = cadena.Split(' ');
            int i = 0;
            for (i = 0; i < c.Length; i = i + 3)
            {
                Console.Write(c[i + 2] + " ");
                Console.Write(c[i + 1] + " ");
                Console.Write(c[i] + " ");
                Console.WriteLine();
            }
        }

        static int[] CuentaLetras(string cadena)
        {
            int[] recuento = new int[7];
            string compara = "abcdefg";
            int i;

            cadena = cadena.ToLower();

            for (i = 0; i < cadena.Length; i++)
            {

                for (int j = 0; j < compara.Length; j++)
                {
                    if (cadena[i] == compara[j])
                    {
                        recuento[j]++;
                    }
                }

            }
            return recuento;

        }

        static string MayusculasMinusculas(string cadena, int opcion)
        {
            int i;
            for (i = 0; i < cadena.Length; i++)
            {
                switch (opcion)
                {
                    case 1:
                        {
                            cadena = cadena.ToLower();
                        }
                        break;
                    case 2:
                        {
                            cadena = cadena.ToUpper();
                        }
                        break;
                    case 3:
                        {
                            cadena = MayusculasPrimera(cadena);
                        }
                        break;
                    case 4:
                        {
                            cadena = PrimeraMayusculaDeFrase(cadena);
                        }
                        break;

                }
            }
            return cadena;

        }

        static string EliminaTags(string cadena)
        {
            string c2 = "";
            int i; 
            for(i = 0; i < cadena.Length; i++)
            {
                c2 = cadena[i] + cadena.Replace("<./*?>", "");
            }
            return c2;
            //int i; 
            //for(i = 0; i < cadena.Length; i++)
            //{
            //    //Hay que hacerlo con IndexOf y con while
            //    //Remove.(pos1, (pos2-ps1+1))
            //    cadena = cadena.R

            //}
        }


        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("MENÚ EJERCICIOS ADICIONALES - CADENAS");
            Console.WriteLine("=====================================");
            Console.WriteLine("[1] EscribeNombres");
            Console.WriteLine("[2] CuentaLetras");
            Console.WriteLine("[3] MayusculasMinusculas");
            Console.WriteLine("[4] EliminaTags");
            Console.WriteLine("[5] ");
            Console.WriteLine("[6] ");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        string nombres = "Torres Garrozo Julian Méndez Muñoz Maria";
                        EscribeNombres(nombres);
                    }
                    break;
                case 2:
                    {
                        string t = "patata camaleon batata";

                        int[] a = CuentaLetras(t);
                        EscribeArray(a);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine(">>>>>>><<<<<<");
                        Console.WriteLine("MAYUS - MINUS");
                        Console.WriteLine(">>>>>>><<<<<<");
                        Console.WriteLine("[1] Todas las letras en minúsculas");
                        Console.WriteLine("[2] Todas las letras en mayúsculas");
                        Console.WriteLine("[3] La primera letra de cada palabra en mayúsculas y el resto en minúsculas");
                        Console.WriteLine("[4] La primera letra de cada frase en mayúsculas y el resto en minúsculas");
                        Console.WriteLine();
                        Console.Write("Elige una de estas 4 opciones: ");
                        int op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Escribe el texto o cadena que quieres modificar");
                        string cad = Console.ReadLine();
                        Console.WriteLine(MayusculasMinusculas(cad, op));

                    }
                    break;
                case 4:
                    {
                        string cadena = "<h1> Título de la cabecera </h1>. Aquí hirá en <strong>negriga</strong> todo el texto.";
                        EscribeCadena(cadena);
                        Console.WriteLine();
                        EliminaTags(cadena);
                        EscribeCadena(cadena);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }

}




