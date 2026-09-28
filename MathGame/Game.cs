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
        public static int numPartida = 1; //Índice de partida (aumenta cuando se juegan varias)
        static List<Partida> listaPartidas = new List<Partida>(); //Registro de partidas
        public static void Main(string[] args)
        {

            int opcion = 0;
            System.Boolean seguirJugando = true;

            //Menú principal: se ejecuta hasta que el usuario decida salir del programa
            do
            {
                //Opciones de la aplicación
                Console.WriteLine("-- MENÚ PRINCIPAL --");
                Console.WriteLine("1. Jugar partida.");
                Console.WriteLine("2. Ver registro de partidas.");
                Console.WriteLine("3. Salir.");
                opcion = Utilidades.leerOpcion();

                switch (opcion)
                {
                    case 1:
                        jugarPartida(); //Ejecuta la partida
                        break;

                    case 2:
                        historialPartidas(); //Muestra historial
                        break;

                    case 3:
                        Console.WriteLine("Saliendo..."); //Cierra el programa
                        seguirJugando = false;
                        break;

                    default:
                        //Vuelve al menú si se elige una opción que no existe
                        Console.WriteLine("Opción inválida. Debes elegir 1/2/3."); 
                        break;
                }
            } while (seguirJugando == true);
        }

        //Partida de 5 preguntas
        public static void jugarPartida()
        {
            int ptsPartida = 0; 
            Partida partidaActual = new Partida(ptsPartida, numPartida);

            int contadorPreguntas = 0;
            int opcion = 0;

            //Menú de partida: se ejecuta hasta que el jugador completa una partida de 5 preguntas
            do
            {
                //Opciones de partida
                Console.WriteLine("MENÚ DE OPERACIONES -- PARTIDA NÚMERO " + partidaActual.NumPartida); //Muestra el índice de la partida
                Console.WriteLine("Elige un tipo de operación: ");
                Console.WriteLine("1. Suma.");
                Console.WriteLine("2. Resta.");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                opcion = Utilidades.leerOpcion();

                switch (opcion)
                {
                    case 1:
                        //Suma
                        CrearOperaciones.crearSuma(partidaActual);
                        contadorPreguntas++;
                        break;
                    case 2:
                        //Resta
                        CrearOperaciones.crearResta(partidaActual);
                        contadorPreguntas++;
                        break;
                    case 3:
                        //Multiplicación
                        CrearOperaciones.crearMultiplicacion(partidaActual);
                        contadorPreguntas++;
                        break;
                    case 4:
                        //División
                        CrearOperaciones.crearDivision(partidaActual);
                        contadorPreguntas++;
                        break;
                    default:
                        //Vuelve al menú si se elige una opción que no existe
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (contadorPreguntas < 5);

            //Resgistra la partida en la lista
            listaPartidas.Add(partidaActual);
            Console.WriteLine("Juego terminado.");
            Console.WriteLine("Partida Guardada. Partida número: " + partidaActual.NumPartida +
                " Puntos obtenidos: " + partidaActual.Puntos);
            numPartida++; //Aumenta el contador de partidas para la próxima que se juegue
        }

        //Muestra las partidas jugadas con su índice y puntuación
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
