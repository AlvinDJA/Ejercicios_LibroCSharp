using System;


namespace Ejercicios_LibroCSharp
{
    class Ejercicio8_3
    {
        public static void hora()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            DateTime tiempo = DateTime.Now;
            Console.WriteLine("La hora y fecha es {0:hh:mm tt - yyyy/dd/MM}", tiempo);
        }
    }

}



