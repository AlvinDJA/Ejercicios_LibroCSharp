using System;


namespace Ejercicios_LibroCSharp
{
    class Ejercicio9_4
    {
        enum Neumatico
        {
            de_verano, de_invierno, all_seasons, asimétricos,
            direccionales, antipinchazos, sin_aire, tubeless
        };
        public static void neumatico()
        {
            Inicializar();
        }
        static void Inicializar()
        {
           Neumatico miNeumatico = Neumatico.de_invierno;
           Console.WriteLine("Mis neumaticos son neumaticos {0}", miNeumatico);
        }

    }

}


