using System;


namespace Ejercicios_LibroCSharp
{
    class Ejercicio6_3
    {
        public static void mayor()
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
                    Console.Write("Dame la calificación ");
                    calif[n][m] = Convert.ToSingle(Console.ReadLine());
                }
            }
            //promedio
            float promedio = 0.0f;
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine($"Salon {n}");
                for (m = 0; m < calif[n].GetLength(0); m++)
                    promedio += calif[n][m];
                promedio /= m;
                Console.WriteLine($"El promedio del salon {n} es {promedio}");
                promedio = 0.0f;
            }
            //menor y mayor
            float menor = 0.0f;
            float mayor = 0.0f;
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine($"Salon {n}");
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    if (n == 0 && m == 0)
                        mayor = menor = calif[n][m];
                    else if (calif[n][m] < menor)
                        menor = calif[n][m];
                    if (calif[n][m] > mayor)
                        mayor = calif[n][m];
                }
            }
            Console.Write($"La menor calificacion es: {menor}");
            Console.Write($"La mayor calificacion es: {mayor}");
        }
    }

}


