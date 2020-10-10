using System;
using System.Collections.Generic;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio10_5
    {
        public class Poligono
        {
            private double lados;
            private double dist;

            public Poligono(double x, double y)
            {
                lados = x;
                dist = y;
            }
            public Poligono()
            {
                lados = 3;
                dist = 5;
            }
            public override string ToString()
            {
                return (lados + " " + dist);
            }
        }
        public static void Poligonos()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            int opcion = 0;
            List<Poligono> pol = new List<Poligono>();
            pol.Add(new Poligono());
            do
            {
                Console.WriteLine("Que desea hacer \n0.Salir\n1.Agregar\n2.Mostrar");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Inserte nombre");
                        double x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Inserte matricula");
                        double y = Convert.ToDouble(Console.ReadLine());

                        pol.Add(new Poligono(x, y));
                        break;
                    case 2:
                        foreach (Poligono item in pol)
                            Console.WriteLine(item.ToString());
                        break;
                    default:
                        Console.WriteLine("Seleccion incorrecta");
                        break;
                }
            } while (true);
        }
    }

}


