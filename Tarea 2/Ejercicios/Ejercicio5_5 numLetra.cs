using System;

namespace Ejercicios_LibroCSharp
{

    class Ejercicio5_5
    {
        public static void factorial(int num)
        {
            int factor = 1;
            for (int i = 1; i <= num; i++)
            {
                factor = factor * i;
            }
            Console.WriteLine(factor);

        }
        public static void factor()
        {
            int num = 0;
            Console.WriteLine("Inserte la cantidad de personas");
            num = Convert.ToInt32(Console.ReadLine());
            factorial(num);

        }

    }
}
