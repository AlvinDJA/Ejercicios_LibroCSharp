﻿using System;

namespace Ejercicios_LibroCSharp
{
    class Program
    {  
        public static void pausa()
        {
            Console.WriteLine("Pulse cualquier letra para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
             char opcion = '0';
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("Tareas\n1)1\n2)2\n0)Salir");
                opcion = Convert.ToChar(Console.ReadLine());
                switch (opcion)
                {
                    case '0':
                        return;
                    case '1':
                        Tarea1.Tarea_1();
                        pausa();
                        break;
                    case '2':
                        Tarea2.Tarea_2();
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
