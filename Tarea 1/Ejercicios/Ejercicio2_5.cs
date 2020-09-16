using System;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio2_5
    {
        public static void dolares( )
        {
            double valor;
            double equivalencia;
            Console.WriteLine("Inserte el valor en Euros :");
            valor = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Cuantos dolares vale un euro?:");
            equivalencia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El valor en Dolares es :{0}", valor*equivalencia);
        }
    }
}
