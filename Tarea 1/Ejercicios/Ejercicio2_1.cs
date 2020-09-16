using System;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio2_1
    {
        public static void perimetro()
        {
            double lados;
            double longuitud;
            Console.WriteLine("Inserte la cantidad de lados:");
            lados = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Inserte la longuitud:");
            longuitud = Convert.ToDouble(Console.ReadLine()); 
            
            Console.WriteLine("El perimetro es {0}", longuitud*lados);
           
        }
    }
}
