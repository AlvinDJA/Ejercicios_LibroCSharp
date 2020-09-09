using System;

namespace Ejercicio_2._1
{
    class Program
    {
        static void Main(string[] args)
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
