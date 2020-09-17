using System;

namespace Ejercicios_LibroCSharp
{

    class Ejercicio5_5
    {
        public static void letras(string num)
        {
            int longuitud = num.Length;
            for (int i = 0; i < longuitud; i++)
            {
                switch (num[i])
                {
                    case '1':
                        Console.Write("Uno");
                        break;
                    case '2':
                        Console.Write("Dos");
                        break;
                    case '3':
                        Console.Write("Tres");
                        break;
                    case '4':
                        Console.Write("Cuatro");
                        break;
                    case '5':
                        Console.Write("Cinco");
                        break;
                    case '6':
                        Console.Write("Seis");
                        break;
                    case '7':
                        Console.Write("Siete");
                        break;
                    case '8':
                        Console.Write("Ocho");
                        break;
                    case '9':
                        Console.Write("Nueve");
                        break;
                    case '0':
                        Console.Write("Cero");
                        break;
                }
                if (i < longuitud-1)
                    Console.Write("-");
            }
            Console.WriteLine("");
        }
        public static void numLetra()
        {
            string num = "0";
            Console.WriteLine("Inserte el numero");
            num = Console.ReadLine();
            letras(num);

        }
    }
}
