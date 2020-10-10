using System;

namespace Ejercicios_LibroCSharp
{
    class Tarea5
    {
        public static void pausa()
        {
            Console.WriteLine("Pulse cualquier letra para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Tarea_5()
        {
            char opcion = '0';
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine
                ("Ejercicios\n1)10.1\n2)10.2\n3)10.3\n4)10.4\n5)10.5");
                Console.WriteLine
                ("6)12.1\n7)12.2\n0)Salir");
                opcion = Convert.ToChar(Console.ReadLine());
                switch (opcion)
                {
                    case '0':
                        return;
                    case '1':
                        Ejercicio10_1.inventario();
                        pausa();
                        break;
                    case '2':
                    Ejercicio10_2.información();
                        pausa();
                        break;
                    case '3':
                    Ejercicio10_3.Poligonos();
                        pausa();
                        break;
                    case '4':
                    Ejercicio10_3.Poligonos();
                        pausa();
                        break;
                    case '5':
                    Ejercicio10_3.Poligonos();
                        pausa();
                        break;
                    case '6':
                    Ejercicio12_1.factor();
                        pausa();
                        break;
                    case '7':
                    Ejercicio12_2.writes();
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
