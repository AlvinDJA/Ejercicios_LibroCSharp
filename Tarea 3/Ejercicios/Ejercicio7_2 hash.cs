using System;
using System.Collections;
using System.Diagnostics;

namespace Ejercicios_LibroCSharp
{
    class Ejercicio7_2
    {
        public static void hash()
        {
            Inicializar();
        }
        static void Inicializar()
        {
            int activad = 0;
            Hashtable diccionario = new Hashtable();
            diccionario.Add("Inefable", "Que no puede ser dicho, explicado o descrito con palabras, generalmente por tener cualidades excelsas o por ser muy sutil o difuso.");
            diccionario.Add("Arbol", "Planta de tronco leñoso, grueso y elevado que se ramifica a cierta altura del suelo formando la copa");
            diccionario.Add("Relampago", "El relámpago es un resplandor muy vivo producido en las nubes por una descarga eléctrica");

            do
            {
                Console.WriteLine("Que desea hacer?\n1)Ver Todo\n2)Agregar");
                activad = Convert.ToInt32(Console.ReadLine());
                switch (activad)
                {
                    case 1:
                        foreach (DictionaryEntry m in diccionario)
                            Console.WriteLine(m.Key + ": " + m.Value);
                        break;
                    case 2:
                        diccionario.Add(Console.ReadLine(), Console.ReadLine());
                        break;
                }
            } while (activad != 0);
        }
    }
}

