using System;

namespace Ejercicio_2._5
{
    class Program
    {
        static void Main(string[] args)
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
