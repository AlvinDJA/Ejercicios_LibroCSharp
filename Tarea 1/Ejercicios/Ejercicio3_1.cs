using System;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio3_1
    {
        public static void parimpar()
        {
            int num;
            Console.WriteLine("Inserte el numero");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es Impar");
        }
    }
}
