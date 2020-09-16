using System;

namespace Ejercicios_LibroCSharp
{
    class Tarea2
    {
        public static void pausa()
        {
            Console.WriteLine("Pulse cualquier letra para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Tarea_2()
        {
            char opcion = '0';
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("Ejercicios\n1)4.1\n2)4.2\n3)4.5\n4)5.4\n5)5.5\n0)Salir");
                opcion = Convert.ToChar(Console.ReadLine());
                switch (opcion)
                {
                    case '0':
                        return;
                    case '1':
                        Ejercicio4_1.tabla();
                        pausa();
                        break;
                    case '2':
                        Ejercicio4_2.elevar();
                        pausa();
                        break;
                    case '3':
                        Ejercicio4_5.edadMinMax();
                        pausa();
                        break;
                    case '4':
                        Ejercicio5_4.factor();
                        pausa();
                        break;
                    case '5':
                        Ejercicio5_5.factor();
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
