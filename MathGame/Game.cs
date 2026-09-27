using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MathGame
{
    class Game
    {
        public static int numPartida = 1;
        static List<Partida> listaPartidas = new List<Partida>();
        public static void Main(string[] args)
        {

            int opcion = 0;
            System.Boolean seguirJugando = true;

            do
            {
                Console.WriteLine("-- MENÚ PRINCIPAL --");
                Console.WriteLine("1. Jugar partida.");
                Console.WriteLine("2. Ver registro de partidas.");
                Console.WriteLine("3. Salir.");
                opcion = Utilidades.leerOpcion();

                switch (opcion)
                {
                    case 1:
                        jugarPartida();
                        break;

                    case 2:
                        historialPartidas();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo...");
                        seguirJugando = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Debes elegir 1/2/3.");
                        break;
                }
            } while (seguirJugando == true);
        }

        public static void jugarPartida()
        {
            int ptsPartida = 0;
            Partida partidaActual = new Partida(ptsPartida, numPartida);

            int contadorPreguntas = 0;
            int opcion = 0;

            do
            {
                Console.WriteLine("MENÚ DE OPERACIONES -- PARTIDA NÚMERO " + partidaActual.NumPartida);
                Console.WriteLine("Elige un tipo de operación: ");
                Console.WriteLine("1. Suma.");
                Console.WriteLine("2. Resta.");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                opcion = Utilidades.leerOpcion();

                switch (opcion)
                {
                    case 1:
                        CrearOperaciones.crearSuma(partidaActual);
                        contadorPreguntas++;
                        break;
                    case 2:
                        CrearOperaciones.crearResta(partidaActual);
                        contadorPreguntas++;
                        break;
                    case 3:
                        CrearOperaciones.crearMultiplicacion(partidaActual);
                        contadorPreguntas++;
                        break;
                    case 4:
                        CrearOperaciones.crearDivision(partidaActual);
                        contadorPreguntas++;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (contadorPreguntas < 5);

            listaPartidas.Add(partidaActual);
            Console.WriteLine("Juego terminado.");
            Console.WriteLine("Partida Guardada. Partida número: " + partidaActual.NumPartida +
                " Puntos obtenidos: " + partidaActual.Puntos);
            numPartida++;
        }

        public static void historialPartidas()
        {
            Console.WriteLine("HISTORIAL DE PARTIDAS:");

            for(int i = 0; i < listaPartidas.Count; i++)
            {
                Console.WriteLine(listaPartidas[i].ToString());
            }
        }
    }
}
