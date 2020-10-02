using System;
using System.Text;
using System.Collections;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio9_1
    {
        public struct Producto
        {
            public String Descripcion;
            public int Cantidad;
            public Decimal Precio;
            public Decimal Costo;

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Descripcion: {0}, Cantidad: {1}, Costo: {2}, Precio: {3}",
                Descripcion, Cantidad, Costo, Precio);
                return (sb.ToString());
            }
            public Producto(String pDescripcion, int pCantidad, Decimal pPrecio, Decimal pCosto)
            {
                Descripcion = pDescripcion;
                Cantidad = pCantidad;
                Precio = pPrecio;
                Costo = pCosto;
            }
        }
        public static void productos()
        {
            Inicializar();
        }
        static void Inicializar()
        {

            string desc;
            int cant;
            decimal cost;
            decimal prec;

            Console.WriteLine("Inserte Descripcion del producto:");
            desc = Console.ReadLine();
            Console.WriteLine("Inserte Cantidad del producto:");
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserte Costo del producto:");
            cost = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Inserte Precio del producto:");
            prec = Convert.ToDecimal(Console.ReadLine());
            Producto p1 = new Producto(desc, cant, prec, cost);
            Console.WriteLine(p1.ToString());
        }
    }

}


