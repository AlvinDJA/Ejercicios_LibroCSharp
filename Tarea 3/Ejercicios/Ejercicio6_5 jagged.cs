using System;


namespace Ejercicios_LibroCSharp
{
    class Ejercicio6_5
    {
        public static void jagged()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m = 0;

            Console.WriteLine("Dame la cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());

            float[][] calif = new float[salones][];
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine($"Dame la cantidad de alumnos para el salon {n}: ");
                cantidad = Convert.ToInt32(Console.ReadLine());
                calif[n] = new float[cantidad];
            }

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine($"Salon {n}");
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.Write("Inserte la calificación ");
                    calif[n][m] = Convert.ToSingle(Console.ReadLine());
                }
            }
            imprimeCalif(calif, salones);
        }
        static public void imprimeCalif(float[][] calif, int salones)
        {
            for (int n = 0; n < salones; n++)
            {
                Console.WriteLine($"Salon {n}");
                for (int m = 0; m < calif[n].GetLength(0); m++)
                    Console.WriteLine($"La califacion {m} es {calif[n][m]}");
            }
        }

    }

}


