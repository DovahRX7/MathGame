using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame
{
    internal class Utilidades
    {
        //Método para leer la respuesta del usuario y comprobar que está en el formato válido
        public static int leerOpcion()
        {
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada no válida. Introduce un número.");
            }
            return opcion;
        }
    }
}
