using System;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio4_1
    {
        public static void tabla()
        {
            int num = 0;

            Console.WriteLine("Inserte el numero para visualizar la tabla");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x {0} = " + num * i, i);
            }
        }
    }
}
