using System;

namespace Ejercicio_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double centigrados;
            Console.WriteLine("Inserte el valor a convertir:");
            centigrados = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("El resultado en Fahrenheit es:{0}", centigrados*9/5+32);
        }
    }
}
