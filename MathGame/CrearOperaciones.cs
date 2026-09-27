using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace MathGame
{
    class CrearOperaciones
    {
        public static void crearSuma(Partida partidaActual)
        {
            int n1 = RandomNumberGenerator.GetInt32(101);
            int n2 = RandomNumberGenerator.GetInt32(101);

            int resultado = n1 + n2;

            Console.WriteLine("Resuelve la operación: ");
            Console.WriteLine(n1 + "+" + n2 + "=");

            int respuesta = Utilidades.leerOpcion();

            comprobarRespuesta(partidaActual, resultado, respuesta);
        }

        public static void crearResta(Partida partidaActual)
        {
            int n1 = RandomNumberGenerator.GetInt32(101);
            int n2 = RandomNumberGenerator.GetInt32(101);

            int resultado = n1 - n2;

            Console.WriteLine("Resuelve la operación: ");
            Console.WriteLine(n1 + "-" + n2 + "=");

            int respuesta = Utilidades.leerOpcion();

            comprobarRespuesta(partidaActual, resultado, respuesta);
        }

        public static void crearMultiplicacion(Partida partidaActual)
        {
            int n1 = RandomNumberGenerator.GetInt32(101);
            int n2 = RandomNumberGenerator.GetInt32(101);

            int resultado = n1 * n2;

            Console.WriteLine("Resuelve la operación: ");
            Console.WriteLine(n1 + "x" + n2 + "=");

            int respuesta = Utilidades.leerOpcion();

            comprobarRespuesta(partidaActual, resultado, respuesta);
        }

        public static void crearDivision(Partida partidaActual)
        {
            System.Boolean sumaValida = false;
            int n1 = 0;
            int n2 = 0;

            do
            {
                n1 = RandomNumberGenerator.GetInt32(101);
                n2 = RandomNumberGenerator.GetInt32(99) + 1; //Evita divisiones entre 0

                if (n1 % n2 == 0)
                {
                    sumaValida = true;
                }

            } while (sumaValida == false);

            int resultado = n1 / n2;

            Console.WriteLine("Resuelve la operación: ");
            Console.WriteLine(n1 + "/" + n2 + "=");

            int respuesta = Utilidades.leerOpcion();

            comprobarRespuesta(partidaActual, resultado, respuesta);
        }

        public static void comprobarRespuesta(Partida partidaActual, int resultado,int respuesta)
        {
            if (resultado == respuesta)
            {
                Console.WriteLine("Respuesta correcta. Obtienes 1 punto.");
                partidaActual.Puntos++;
            }
            else
            {
                Console.WriteLine("Respuesta incorrecta. A estudiar.");
            }
        }
    }
}
