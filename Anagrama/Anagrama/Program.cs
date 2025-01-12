using System;
using System.Collections.Immutable;

namespace Anagrama
{

    class Program
    {

        static void Main(string[] args)
        {
            string palabra1 = "hola";
            string palabra2 = "hlao";
                

            if (sonAnagramas(palabra1, palabra2) && palabra1.SequenceEqual(palabra2)== false)
            {
                Console.WriteLine("si son anagramas");

            }
            else
            { Console.WriteLine(" no son anagramas");
            }

            Console.WriteLine(default(int));
            Console.WriteLine(Math.
        }



        static bool sonAnagramas(string palabra1, string palabra2)
        {
            if (palabra1.Length != palabra2.Length) {
                return false;
                    }
            char[] caracteres1 = palabra1.ToCharArray();
            char[] caracteres2 = palabra2.ToCharArray();

            Array.Sort(caracteres1);
            Array.Sort(caracteres2);

            return caracteres1.SequenceEqual(caracteres2);
        }
    }
}
