using System;


namespace Ejercicios_LibroCSharp
{
    class Ejercicio8_5
    {
        public static void cadenas()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            Console.WriteLine("Inserte cadana 1");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("Inserte cadana 2");
            string cadena2 = Console.ReadLine();
            if (string.Compare(cadena1, cadena2) < 0)
                Console.WriteLine(cadena1 + "\n" + cadena2);
            else
                Console.WriteLine(cadena2 + "\n" + cadena1);

        }
    }

}


