using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace MathGame
{
    class CrearOperaciones
    {
        //Suma
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

        //Resta
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

        //Multiplicación
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

        //División
        public static void crearDivision(Partida partidaActual)
        {
            System.Boolean divValida = false;
            int n1 = 0;
            int n2 = 0;

            //Asegura que el resultado de la división sea entero
            do
            {
                n1 = RandomNumberGenerator.GetInt32(101);
                n2 = RandomNumberGenerator.GetInt32(99) + 1; //Evita divisiones entre 0

                if (n1 % n2 == 0)
                {
                    divValida = true;
                }

            } while (divValida == false);

            int resultado = n1 / n2;

            Console.WriteLine("Resuelve la operación: ");
            Console.WriteLine(n1 + "/" + n2 + "=");

            int respuesta = Utilidades.leerOpcion();

            comprobarRespuesta(partidaActual, resultado, respuesta);
        }

        //Comprueba si la respuesta que da el usuario a una operación es correcta y suma un punto si lo es
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
