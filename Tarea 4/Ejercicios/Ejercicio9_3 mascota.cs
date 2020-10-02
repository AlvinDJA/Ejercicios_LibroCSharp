using System;
using System.Text;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio9_3
    {

        public static void mascotadueno()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            Console.WriteLine("Inserte nombre del dueño, cedula, nombre de la mascota"+
            " raza y su color");
            Dueno n1 = new Dueno(Console.ReadLine(),
                        Console.ReadLine(),Console.ReadLine(),
                        Console.ReadLine(),Console.ReadLine());
            Console.WriteLine(n1);
        }
        public struct Mascota
        {
            public string Nombre;
            public string Raza;
            public string Color;
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Raza: {1}, Color: {2}",
                Nombre, Raza, Color );
                return (sb.ToString());
            }
            public Mascota(string nombre, string raza, string color)
            {
                Nombre = nombre;
                Raza = raza;
                Color = color;
            }
        }
        public struct Dueno
        {
            public string Nombre;
            public string Cedula;
            public Mascota mascota;

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Dueño---Nombre: {0}, Cedula: {1}, Mascota---{2}",
                Nombre, Cedula, mascota.ToString());
                return (sb.ToString());
            }
            public Dueno(string nombre,string cedula,string  mNombre,string  raza, string color)
            {
                Nombre = nombre;
                Cedula = cedula;
                mascota = new Mascota(mNombre, raza, color);
            }
        }
    }
}

