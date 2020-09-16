using System;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio2_4
    {
        public static void Fahrenheit()
        {
            double centigrados;
            Console.WriteLine("Inserte el valor a convertir:");
            centigrados = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("El resultado en Fahrenheit es:{0}", centigrados*9/5+32);
        }
    }
}
