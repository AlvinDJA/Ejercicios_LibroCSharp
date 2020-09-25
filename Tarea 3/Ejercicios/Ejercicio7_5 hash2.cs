using System;
using System.Collections;
using System.Diagnostics;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio7_5
    {
        public static void hash2()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            int activad = 0;
            Hashtable agenda = new Hashtable();
            agenda.Add("8095554444", "Pedro Almanzar");
            do
            {
                Console.WriteLine("Que desea hacer?\n1)Ver Todo\n2)Agregar");
                activad = Convert.ToInt32(Console.ReadLine());
                switch (activad)
                {
                    case 1:
                        foreach (DictionaryEntry m in agenda)
                            Console.WriteLine(m.Key + ": " + m.Value);
                        break;
                    case 2:
                        agenda.Add(numero(), nombre());
                        break;
                }
            } while (activad != 0);
        }
        static public string nombre()
        {
            Console.WriteLine("Inserte el nombre: ");
            return Console.ReadLine();
        }
        static public string numero()
        {
            Console.WriteLine("Inserte el numero: ");
            return Console.ReadLine();
        }
    }
}

