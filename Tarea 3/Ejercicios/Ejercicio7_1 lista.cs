using System;
using System.Collections;
using System.Diagnostics;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio7_1
    {
        public static void list()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            ArrayList calificaciones = new ArrayList();
            Console.WriteLine("Digite la cantidad de alumnos: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (int m = 0; m < cantidad; m++)
            {
                Console.Write("Inserte la calificación ");
                calificaciones.Add(Convert.ToDouble(Console.ReadLine()));
            }
            double suma = 0;
            double menor, mayor;
            menor = mayor = suma;
            for (int i = 0; i < cantidad; i++)
            {
                suma += Convert.ToDouble(calificaciones[i]);
                if (i == 0)
                {
                    mayor = menor = Convert.ToDouble(calificaciones[i]);
                }
                else if (Convert.ToDouble(calificaciones[i]) > mayor)
                {
                    mayor = Convert.ToDouble(calificaciones[i]);
                }
                else if (Convert.ToDouble(calificaciones[i]) < menor)
                {
                    menor = Convert.ToDouble(calificaciones[i]);
                }
            }
            suma /= cantidad;
            Console.WriteLine($"El promedio de las calificaciones es: {suma}");
            Console.WriteLine($"La califacion maxima es: {mayor}");
            Console.WriteLine($"La califacion minima es: {menor}");

        }
    }
}

