using System;

namespace Ejercicio_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("Inserte el dia (1 al 7)");
            dia = Convert.ToInt32(Console.ReadLine());

            switch(dia)
            {
                case 1:
                    Console.WriteLine("Es Domingo");
                    break;
                case 2:
                    Console.WriteLine("Es Lunes");
                    break;
                case 3:
                    Console.WriteLine("Es Martes");
                    break;
                case 4:
                    Console.WriteLine("Es Miercoles");
                    break;  
                case 5:
                    Console.WriteLine("Es Jueves");
                    break;
                case 6:
                    Console.WriteLine("Es Viernes");
                    break;
                case 7:
                    Console.WriteLine("Es Sabado");
                    break;
                default: Console.WriteLine("No es un dia valido"); break;
            }

        }
    }
}
