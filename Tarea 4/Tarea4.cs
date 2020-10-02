using System;

namespace Ejercicios_LibroCSharp
{
    class Tarea4
    {
        public static void pausa()
        {
            Console.WriteLine("Pulse cualquier letra para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Tarea_4()
        {
            char opcion = '0';
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("Ejercicios\n1)8.3\n2)8.5\n3)9.1\n4)9.3\n5)9.4\n0)Salir");
                opcion = Convert.ToChar(Console.ReadLine());
                switch (opcion)
                {
                    case '0':
                        return;
                    case '1':
                        Ejercicio8_3.hora();
                        pausa();
                        break;
                    case '2':
                        Ejercicio8_5.cadenas();
                        pausa();
                        break;
                    case '3':
                        Ejercicio9_1.productos();
                        pausa();
                        break;
                    case '4':
                        Ejercicio9_3.mascotadueno();
                        pausa();
                        break;
                    case '5':
                        Ejercicio9_4.neumatico();
                        pausa();
                        break;
                    default:
                        Console.WriteLine("Opcion no valdia!"); break;
                }
                pausa();
            } while (opcion != 0);

        }
    }
}
