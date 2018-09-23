 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;//Añadimos esta extensión para poder usar métodos necesarios
                                     //en la función "VecesPalabras"

namespace Cadenas_1
{
    class Program
    {
        /// <summary>
        /// Función que cuenta los espacios que contiene una cadena
        /// </summary>
        /// <param name="cadena">Nombre del parámetro de la función</param>
        /// <returns>Devuelve entero con el recuento de espacios encontrados en la cadena</returns>
        static int NumeroEspacios(string cadena)
        {
            int i;
            int contador = 0;

            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')//Si algún elemento es un espacio...
                {
                    contador = contador + 1;//...contador de espacios encontrados
                }
            }
            return contador;
        }

        /// <summary>
        /// Función que contabiliza las vocales encontradas en una cadena
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función</param>
        /// <returns>Devuelve entero con el número de vocales encontradas en el string</returns>
        static int NumeroVocales(string cadena)
        {
            int i, vocales;
            vocales = 0;
            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == 'a' || cadena[i] == 'A')
                {
                    vocales++;
                }
                else if (cadena[i] == 'e' || cadena[i] == 'E')
                {
                    vocales++;
                }
                else if (cadena[i] == 'i' || cadena[i] == 'I')
                {
                    vocales++;
                }
                else if (cadena[i] == 'o' || cadena[i] == 'O')
                {
                    vocales++;
                }
                else if (cadena[i] == 'u' || cadena[i] == 'U')
                {
                    vocales++;
                }
            }
            return vocales;
        }

        /// <summary>
        /// Función que determina si un char o string es palíndromo 
        /// </summary>
        /// <param name="c">Determina el parámetro de la función</param>
        /// <returns>Devuelve respuesta booleana ante el resultado de la comprobación</returns>
        static bool EsPalindromo(string c)
        {
            bool palindromo;//Booleano para devolver true/false ante ser o no palíndromo
            string invertido = "";//String para guardar copia de cadena, y modificar esa copia
            int i;//Contador de bucle
            for (i = c.Length - 1; i >= 0; i--)//Bucle que sirve para invertir cadena
            {
                invertido += c[i];//Copia los elementos de c en invertido (va copiando desde el último
            }                     //hasta el primero para quedar invertido)

            invertido = invertido.Replace(" ", "");//Hacemos un replace a los espacios de la cadena invetida
            c = c.Replace(" ", "");                //y también de la cadena original                       
            invertido = invertido.ToLower(); //Pasamos ambos strings a minúsculas para solvertar la confusión
            c = c.ToLower();                 //entre mayúsculas y minúsculas                       

            if (invertido == c)//Ahora comparamos los estados de una y otra despues de los replace
            {                 //esto es por si se trata de una frase (es por eso que le quito los espacios) 
                palindromo = true;
            }
            else
            {
                palindromo = false;
            }
            return palindromo;
        }

        /// <summary>
        /// Función que repite un caracter tantas veces como indique el entero que la relaciona
        /// </summary>
        /// <param name="caracter">Primero parámetro de la función y determina el caracter que pasamos</param>
        /// <param name="entero">Segundo parámetro de la función y determina el entero que pasamos</param>
        static string RepiteCaracter(char caracter, int entero)
        {
            int i;
            //Console.Write("[" + caracter);
            string cadena = "";
            for (i = 0; i < entero - 1; i++)
            {
                //Console.Write(",");
                //Console.Write(caracter);
                cadena = cadena + caracter;
            }
            //Console.Write("]");
            return cadena;
        }

        /// <summary>
        /// Función que busca el contenido de un caracter en el string y te dice si lo contiene
        /// </summary>
        /// <param name="cadena">Primer parámetro de la función y pertenece al string que recorremos</param>
        /// <param name="letra">Segundo parámetro de la función y pertenece al caracter que buscamos en el string</param>
        static bool Contiene(string cadena, char letra)
        {
            int i;
            int contieneSi = 0;//Contador para las veces que sí lo contiene
            //int contieneNo = 0;//Contador para las veces que no lo contiene
            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == letra)
                {
                    contieneSi++;
                }
                //else
                //{
                //    contieneNo++;
                //}
            }
            if (contieneSi >= 1)//Jugamos con las veces que sí contiene
            {
                //Console.WriteLine($"Contiene el caracter ==> \"{letra}\"");
                return true;
            }
            else
            {
                //Console.WriteLine($"No contiene el caracter ==> {letra}");
                return false;
            }

        }

        /// <summary>
        /// Función que quita todos los espacios que aparecen en un string
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función y el string de la misma.</param>
        static string QuitaEspacios(string cadena)
        {
            string sin = ""; //Cadena vacía que sustituirá a los espacios
            int i; 
            for(i = 0; i < cadena.Length; i++)
            {
                while(cadena[i] == ' ')
                {
                    cadena = cadena.Insert(i, sin);
                    cadena = cadena.Remove(i, 1);
                }
            }
            return cadena;
            //int i;
            //for (i = 0; i < cadena.Length; i++)
            //{
            //    cadena = cadena.Replace(" ", "");
            //}
            //return cadena;
        }

        /// <summary>
        /// Función que quita los espacios al principio y al final de la cadena ("No los intermedios")
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función y la cadena</param>
        static string QuitaEspaciosTrim(string cadena)
        {
            while (cadena[0] == ' ')
            {
                cadena = cadena.Remove(0, 1);
            }
            while (cadena[cadena.Length - 1] == ' ')
            {
                cadena = cadena.Remove(cadena.Length - 1, 1);
            }
            return cadena;
        }

        /// <summary>
        /// Función que sustituye un caracter cualquiera, por otro, dentro de un string.
        /// </summary>
        /// <param name="cadena">Determina el primer parámetro de la función, y el string de la misma</param>
        /// <param name="c1">Determina el segundo parámetro de la función correspondiente al caracter que se va a sustituir</param>
        /// <param name="c2">Deterima el tercer parámetro de la función correspondiente al caracter nuevo caracter</param>
        /// <returns>Devuelve copia del string con los cambios realizados</returns>
        static string SustituyeCaracter(string cadena, char c1, char c2)
        {
            //string[] nuevo = new string[cadena.Length];
            int i;
            string cadena2 = "";
            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == c1)
                {
                    cadena2 = cadena2 + c2;
                }
                else
                {
                    cadena2 = cadena2 + cadena[i];
                }
            }
            //cadena = cadena.Replace(c1, c2);
            return cadena2;
        }

        /// <summary>
        /// Función que cuenta las palabras de una cadena
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función y la cadena</param>
        /// <returns>Devuelve número de palabras encontradas</returns>
        static int CuentaPalabras(string cadena)
        {
            int i;
            int contador = 0;
            cadena = ' ' + cadena;
            for (i = 1; i < cadena.Length - 1; i++)
            {
                if (cadena[i] == ' ' && Char.IsLetter(cadena[i + 1]))
                {
                    contador++;
                }
            }
            return contador + 1;
        }

        /// <summary>
        /// Función que detecta si una cadena está formada por enteros
        /// </summary>
        /// <param name="cadena">Determina el primer parámetro de la función</param>
        /// <returns>Devuelve resultado boleano en respuesta a cadena de enteros o no.</returns>
        static bool EsNumero(string cadena)
        {
            int i;
            bool es = true;
            for (i = 0; i < cadena.Length; i++)
            {
                if (!Char.IsDigit(cadena, i))
                {
                    es = false;
                }
            }
            return es;
        }

        /// <summary>
        /// Función que elimina un caracter a elegir, y deja los huecos generados por ellos en el string
        /// </summary>
        /// <param name="cadena">Determina primer parámetro de la función y denomina la cadena</param>
        /// <param name="caracter">Determina segundo parámetro de la función y denomina el caracter</param>
        static string QuitaCaracter(string cadena, char caracter)
        {
            int i;
            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == caracter)
                {
                    cadena = cadena.Insert(i, " ");
                    cadena = cadena.Remove(i + 1, 1);
                }
            }
            return cadena;


            //int i;
            //char hueco = ' ';
            //for (i = 0; i < cadena.Length; i++)
            //{
            //    //Metodo hecho con Replace
            //    cadena = cadena.Replace(caracter, hueco);
            //}
            //return cadena;
        }

        /// <summary>
        /// Función que cambia a mayúscula el primer caracter de todas las palabras del string
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función y el string de la misma</param>
        static string MayusculasPrimera(string cadena)
        {
            // Para sustituir en una cadena, podemos ir copiando a otra cadena e ir cambiando los elementos
            string cadena2 = "";
            // string cadena2 = char.ToUpper(cadena[0]).ToString(); // ToString para que el caracter lo convierta en un string de 1 carácter
            int i;
            cadena2 = cadena2 + char.ToUpper(cadena[0]);
            // Yo prefiero cadena = " " + cadena;
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

        /// <summary>
        /// Función que quita acentos en textos
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función y el string de la misma</param>
        /// <returns>Devuelve texto modificado sin acentos</returns>
        static string QuitaAcentos(string cadena)
        {
            //Declaramos dos string, uno que contenga signos y otro que no los contenga
            string consignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜÑçÇ";
            string sinsignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUUNcC";
            //Creamos condicional que compruebe la coincidencia en tamaño del los string
            //anteriormente creados (esto evita posibles errores a la hora de seguir con el código)
            if (consignos.Length != sinsignos.Length)
            {
                throw new Exception("Revise las cadenas para la sustitución de acentos (longitud/datos)");
            }
            //Creamos variable para los ejemplares con o sin acento, y será del tamaño indicado
            int elementos = consignos.Length;
            //Creamos un string que nos retorna el cambio realizado en cadena
            string retorno = cadena;
            //Bucle for que recorre el número de elementos con o sin encontrados en cadena
            for (int i = 0; i < elementos; i++)
            {
                //Ahora, por cada elemento encontrado hacemos un replace de los caracteres
                retorno = retorno.Replace(consignos[i], sinsignos[i]);
            }
            return retorno;

        }

        /// <summary>
        /// Función invierte un string
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función y el string de la misma</param>
        /// <returns>Devuelve cadena invertida</returns>
        static string InvierteCadena(string cadena)
        {
            string invertida = "";
            int i;
            for (i = 0; i < cadena.Length; i++)
            {
                invertida = cadena[i] + invertida;
            }
            return invertida;

            ////>>Hecho con Array.Reverse<<<
            //char[] delreves = cadena.ToCharArray();
            //Array.Reverse(delreves);
            //return new string(delreves);
        }

        /// <summary>
        /// Función que recuenta las veces que aparece determinado caracter dentro de un string
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función y el string de la misma</param>
        /// <param name="caracter">Determina el segundo parámetro de la función y el caracter</param>
        /// <returns>Devuelve número de veces que aparece el caracter dentro de la cadena</returns>
        static int VecesCaracter(string cadena, char caracter)
        {
            int i, contador;
            contador = 0;
            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == caracter)
                {
                    contador++;
                }
            }
            return contador;
        }

        /// <summary>
        /// Función que hace recuento de palabras iguales encontradas.
        /// </summary>
        /// <param name="cadena">Determina el primer parámetro de la función y el string que hay que analizar</param>
        /// <param name="palabra">Determina el segundo parámetro de la función y el string palabra que se busca</param>
        /// <returns>Devuelve número de veces que aparece la palabra buscada</returns>
        static int VecesPalabra(string cadena, string palabra)
        {
            int contador = 0;//Contador de veces palabra
            string[] c2 = { };//Creamos una array de string, para que al hacerle Split a la cadena guarde la misma en trozos (los trozos de espacio a espacio)
            cadena = cadena.ToLower();//Convertimos los caracteres a minuscula para que reconozca aquellas palabras que estén en mayuscula.
            c2 = cadena.Split(' ');//Hacemos Split por los espacios, y así almacenamos por palabras.            
            for (int i = 0; i < c2.Length; i++)
            {
                if (c2[i] == palabra)
                {
                    contador++;
                }
            }
            return contador;

            //int contador = 0;
            //cadena = cadena.ToLower();
            //foreach (Match item in Regex.Matches(cadena, palabra))
            //{  //>>HECHO CON EXPRESIÓN REGULAR<<
            //    contador++;
            //}
            //return contador;
        }

        /// <summary>
        /// Función que sustituye palabras en una cadena
        /// </summary>
        /// <param name="cadena">Determina el primer parámetro de la función. Corresponde con el string que se va a analizar.</param>
        /// <param name="vieja">Determina el segundo parámetro. Corresponde con la palabra que será reemplazada</param>
        /// <param name="nueva">Determina el tercer parámetro. Refiere la nueva palabra</param>
        static string SustituyePalabra(string cadena, string vieja, string nueva)
        {
            int i;
            //string cadena2;
            for (i = 0; i < cadena.Length; i++)
            {
                cadena = cadena.Replace(vieja, nueva);
            }
            //Console.WriteLine(cadena);
            return cadena;
        }

        /// <summary>
        /// Función que marca con asterisco el primer caracter de una subcadena
        /// </summary>
        /// <param name="cadena">Determina el primer parámetro de la función y la cadena a analizar</param>
        /// <param name="subcadena">Determina el segundo parámetro de la función y la subcadena</param>
        /// <returns>Devuelve cadena con subcadena modificada</returns>
        static string MarcaSubCadena(string cadena, string subcadena)
        {
            int i;
            //string sub = '*' + subcadena.Substring(1);//Esto se usa para el Replace
            string cacho;
            for (i = 0; i < cadena.Length - (subcadena.Length - 1); i++)
            {
                cacho = cadena.Substring(i, subcadena.Length);
                if (cacho == subcadena)
                {
                    //cadena[i] = '*';
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, "*");
                }
                //Console.WriteLine(cadena);
            }

            return cadena;
        }

        /// <summary>
        /// Función que devuelve una cadena con las palabras invertidas
        /// </summary>
        /// <param name="frase">Determina el parámetro de la función y el string de la misma</param>
        /// <returns>Devuelve string con palabras invertidas en su propio lugar</returns>
        static string InviertePalabras(string frase)
        {
            int i;
            string[] palabrasFrase = frase.Split(' ');
            string fraseInvertida = "";

            for (i = 0; i < palabrasFrase.Length; i++)
            {
                string palabraInvertida = InvierteCadena(palabrasFrase[i]);

                fraseInvertida += palabraInvertida + " ";
            }
            fraseInvertida = fraseInvertida.Remove(fraseInvertida.Length - 1);
            return fraseInvertida;
        }

        /// <summary>
        /// Función que quita los espacios sobrantes de una cadena.
        /// </summary>
        /// <param name="cadena">Determina el parámetro de la función y el string de la misma</param>
        /// <returns>Devuelve cadena sin espacios sobrantes</returns>
        static string QuitaEspaciosSobrantes(string cadena)
        {
            cadena = QuitaEspaciosTrim(cadena);
            int i;
            for (i = 0; i < cadena.Length - 1; i++)
            {
                if (cadena[i] == ' ' && ' ' != 1)
                {
                    cadena = cadena.Remove(i, 1);
                }
            }
            return cadena;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("==============");
            Console.WriteLine("MENÚ CADENAS 1");
            Console.WriteLine("==============");
            Console.WriteLine("[1] NumeroEspacios");
            Console.WriteLine("[2] NumeroVocales");
            Console.WriteLine("[3] EsPalindromo");
            Console.WriteLine("[4] Contiene");
            Console.WriteLine("[5] RepiteCaracter");
            Console.WriteLine("[6] QuitarEspacios");
            Console.WriteLine("[7] QuitaEspaciosTrim");
            Console.WriteLine("[8] SustituyeCaracter");
            Console.WriteLine("[9] CuentaPalabras");
            Console.WriteLine("[10] EsNumero");
            Console.WriteLine("[11] QuitaCaracter");
            Console.WriteLine("[12] MayusculasPrimera");
            Console.WriteLine("[13] QuitaAcentos");
            Console.WriteLine("[14] InvierteCadena");
            Console.WriteLine("[15] VecesCaracter");
            Console.WriteLine("[16] VecesPalabra");
            Console.WriteLine("[17] SustituyePalabra");
            Console.WriteLine("[18] MarcaSubCadena");
            Console.WriteLine("[19] InviertePalabras");
            Console.WriteLine("[20] QuitaEspaciosSobrantes");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Escribe una cadena para contar cuántos espacios contiene");
                        string cadena = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine($"Son \"{NumeroEspacios(cadena)}\" los espacios encontrados en la cadena.");
                    }
                    break;
                case 2:
                    {
                        string c;
                        Console.WriteLine("Escribe una cadena para contar sus vocales: ");
                        c = Console.ReadLine();
                        Console.WriteLine($"La cadena escrita contiene {NumeroVocales(c)} vocales");

                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Escribe la palabra o frase para decirte si es palíndromo: ");
                        string c = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine($"La frase o caracter indicado con respecto a ser palíndromo devuelve \"{EsPalindromo(c)}\"");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Escribe el texto");
                        string cadena = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Qué caracter quieres buscar ??:  ");
                        char letra = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine(Contiene(cadena, letra));
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Escribe el caracter: ");
                        char caracter = char.Parse(Console.ReadLine());
                        Console.WriteLine($"Escribe el número de veces que quieres que \"{caracter}\" se repita");
                        int entero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(RepiteCaracter(caracter, entero));
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Escribe un texto para el ejercicio");
                        string texto = Console.ReadLine();
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("<" + QuitaEspacios(texto) + ">");

                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Escribe el string para eleminar sus espacios al principio y al final");
                        string texto = Console.ReadLine();
                        Console.WriteLine("<" + QuitaEspaciosTrim(texto) + ">");
                    }
                    break;
                case 8:
                    {
                        string cadena = "";
                        char viejo;
                        char nuevo;
                        Console.WriteLine("Escribe el texto para cambiar un caracter por otro");
                        cadena = Console.ReadLine();
                        Console.WriteLine("Qué caracter del texto será reemplazado ?");
                        viejo = char.Parse(Console.ReadLine());
                        Console.WriteLine("Qué caracter sustituirá al viejo ?");
                        nuevo = Convert.ToChar(Console.ReadLine());

                        Console.WriteLine(SustituyeCaracter(cadena, viejo, nuevo));
                    }
                    break;
                case 9:
                    {
                        string texto;
                        Console.WriteLine("Escribe el texto para contar las palabras del mismo");
                        texto = Console.ReadLine();
                        Console.WriteLine($"El texto contiene \"{CuentaPalabras(texto)}\" palabras.");
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("Escribe el string para decirte si está formado por enteros o no");
                        string texto = Console.ReadLine();
                        Console.WriteLine(EsNumero(texto));
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("Escribe la cadena: ");
                        string cadena = Console.ReadLine();
                        Console.WriteLine("Escribe el caracter que quieres quitar: ");
                        char caracter = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine(QuitaCaracter(cadena, caracter));
                    }
                    break;
                case 12:
                    {
                        string cadena;
                        Console.WriteLine("Escribe un texto para pasar a mayuscula el primer caracter de sus palabras.");
                        cadena = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine(MayusculasPrimera(cadena));
                    }
                    break;
                case 13:
                    {
                        string texto;
                        Console.WriteLine("Escribe el texto para quitar sus acentos");
                        texto = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine(QuitaAcentos(texto));
                    }
                    break;
                case 14:
                    {
                        string cadena;
                        Console.WriteLine("Escribe el texto que quieres invertir");
                        cadena = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine(InvierteCadena(cadena));

                    }
                    break;
                case 15:
                    {
                        string texto;
                        char caracter;
                        Console.WriteLine("Escribe el texto");
                        texto = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Cuál es el caracter que quieres saber las veces que aparece en el texto ?? => ");
                        caracter = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"El caracter \"{caracter}\" aparece {VecesCaracter(texto, caracter)} veces.");
                    }
                    break;
                case 16:
                    {
                        string texto, palabra;
                        Console.WriteLine("Escribe el texto");
                        texto = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Escribe la palabra que quieres saber cuántas veces aparece en el texto:");
                        palabra = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine($"La palabra \"{palabra}\" aparece \"{VecesPalabra(texto, palabra)}\" veces en el texto.");
                    }
                    break;
                case 17:
                    {
                        string cadena, vieja, nueva;
                        Console.WriteLine("Escribe el texto");
                        cadena = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Escribe la palabra que quieres reemplazar");
                        vieja = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Escribe nueva palabra");
                        nueva = Console.ReadLine();
                        Console.WriteLine(SustituyePalabra(cadena, vieja, nueva));


                    }
                    break;
                case 18:
                    {
                        string texto;
                        string palabra;

                        Console.WriteLine("Escribe el texto");
                        texto = Console.ReadLine();
                        Console.WriteLine("Escribe la palabra para modificarla");
                        palabra = Console.ReadLine();
                        Console.WriteLine(MarcaSubCadena(texto, palabra));
                    }
                    break;
                case 19:
                    {
                        Console.WriteLine("Escribe la cadena para invertir sus palabras");
                        string cadena = Console.ReadLine();
                        Console.WriteLine(InviertePalabras(cadena));
                    }
                    break;
                case 20:
                    {
                        Console.WriteLine("Escribe el texto");
                        string t = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine(QuitaEspaciosSobrantes(t));
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}



