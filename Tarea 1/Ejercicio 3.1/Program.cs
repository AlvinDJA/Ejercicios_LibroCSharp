using System;

namespace Ejercicio_3._1
{
    class Program
    {
        static void Main(string[] args)
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
