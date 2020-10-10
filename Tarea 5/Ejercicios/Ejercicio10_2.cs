using System;
using System.Collections.Generic;

namespace Ejercicios_LibroCSharp
{
    // 2 Crear una clase para llevar la
    // información de los estudiantes de una
    // escuela.

    class Ejercicio10_2
    {
        public class Estudiante
        {
            private string nombre;
            private string matricula;
            private double nota;

            public Estudiante(string nomb, string mat, double not)
            {
                nombre = nomb;
                matricula = mat;
                nota = not;
            }
            public override string ToString()
            {
                return (nombre + " " + matricula + " " + nota);
            }
        }
        public static void información()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            int opcion = 0;
            List<Estudiante> prod = new List<Estudiante>();
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
                        string nom = Console.ReadLine();

                        Console.WriteLine("Inserte matricula");
                        string mat = Console.ReadLine();

                        Console.WriteLine("Inserte nota");
                        double nt = Convert.ToDouble(Console.ReadLine());

                        prod.Add(new Estudiante(nom, mat, nt));
                        break;
                    case 2:
                        foreach (Estudiante item in prod)
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


