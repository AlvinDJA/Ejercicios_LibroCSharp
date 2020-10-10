using System;


namespace Ejercicios_LibroCSharp
{
    class Ejercicio12_1
    {

        public static int factorial(int numero)
        {
            int resultado = 1;

            for (int i = numero; i > 1; i--)
                resultado *= i;
            return resultado;
        }
        public static void factor()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El factorial es {0}", factorial(numero));
        }
    }

}



