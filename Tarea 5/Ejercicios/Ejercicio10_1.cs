using System;
using System.Collections.Generic;

// 1 Crear el diseño de una clase para llevar
// el inventario de una tienda.

namespace Ejercicios_LibroCSharp
{
    class Ejercicio10_1
    {
        public class Producto
        {
            private string descripcion;
            private int cantidad;
            private double precio;
            private double costo;

            public Producto(string desc, int cant, double pre, double cost)
            {
                descripcion = desc;
                cantidad = cant;
                precio = pre;
                costo = cost;
            }
            public override string ToString()
            {
                return (descripcion + " " + cantidad + " " + precio + " " + costo);
            }
        }
        public static void inventario()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            int opcion = 0;
            List<Producto> prod = new List<Producto>();
            do
            {
                Console.WriteLine("Que desea hacer \n0.Salir\n1.Agregar\n2.Mostrar");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Inserte descripcion");
                        string des = Console.ReadLine();
                        Console.WriteLine("Inserte cantidad");
                        int cant = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserte precio");
                        double pr = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Inserte costo");
                        double cos = Convert.ToDouble(Console.ReadLine());
                        prod.Add(new Producto(des, cant, pr, cos));
                        break;
                    case 2:
                        foreach (Producto item in prod)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Seleccion incorrecta");
                        break;

                }
            } while (true);
        }
    }

}



