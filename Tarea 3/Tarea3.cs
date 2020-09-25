using System;

namespace Ejercicios_LibroCSharp
{
    class Tarea3
    {
        public static void pausa()
        {
            Console.WriteLine("Pulse cualquier letra para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Tarea_3()
        {
            char opcion = '0';
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("Ejercicios\n1)6.1\n2)6.2\n3)6.3\n4)6.4\n5)6.5\n6)7.1\n7)7.2\n8)7.5\n0)Salir");
                opcion = Convert.ToChar(Console.ReadLine());
                switch (opcion)
                {
                    case '0':
                        return;
                    case '1':
                        Ejercicio6_1.promedio();
                        pausa();
                        break;
                    case '2':
                        Ejercicio6_2.menor();
                        pausa();
                        break;
                    case '3':
                        Ejercicio6_3.mayor();
                        pausa();
                        break;
                    case '4':
                        Ejercicio6_4.func();
                        pausa();
                        break;
                    case '5':
                        Ejercicio6_5.jagged();
                        pausa();
                        break;
                    case '6':
                        Ejercicio7_1.list();
                        pausa();
                        break;
                    case '7':
                        Ejercicio7_2.hash();
                        pausa();
                        break;
                    case '8':
                        Ejercicio7_5.hash2();
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
