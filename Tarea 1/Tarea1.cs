using System;

namespace Ejercicios_LibroCSharp
{
    class Tarea1
    {
        public static void pausa()
        {
            Console.WriteLine("Pulse cualquier letra para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Tarea_1()
        {
            char opcion = '0';
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("Ejercicios\n1)1.1\n2)1.5\n3)2.1\n4)2.3\n5)2.4\n6)2.5\n7)3.1\n8)3.4\n0)Salir");
                opcion = Convert.ToChar(Console.ReadLine());
                switch (opcion)
                {
                    case '0':
                        return;
                    case '1':
                        Ejercicio1_1.nombre();
                        pausa();
                        break;
                    case '2':
                        Ejercicio1_5.datos();
                        pausa();
                        break;
                    case '3':
                        Ejercicio2_1.perimetro();
                        pausa();
                        break;
                    case '4':
                        Ejercicio2_3.radianes();
                        pausa();
                        break;
                    case '5':
                        Ejercicio2_4.Fahrenheit();
                        pausa();
                        break;
                    case '6':
                        Ejercicio2_5.dolares();
                        pausa();
                        break;
                    case '7':
                        Ejercicio3_1.parimpar();
                        pausa();
                        break;
                    case '8':
                        Ejercicio3_4.dia();
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
