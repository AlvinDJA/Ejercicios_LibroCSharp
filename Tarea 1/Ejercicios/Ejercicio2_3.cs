using System;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio2_3
    {
        public static void radianes()
        {
            double grados;
            Console.WriteLine("Inserte los grados a convertir:");
            grados = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("El resultado en radianes es:{0}", grados* Math.PI/180);
        }
    }
}
