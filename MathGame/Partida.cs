using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame
{
    public class Partida
    {
        //Atributos
        public int Puntos { get; set; }
        public int NumPartida { get; set; }
  
        //Constructor
        public Partida(int puntos, int numPartida)
        {
            Puntos = puntos;
            NumPartida = numPartida;
 
        }

        //ToString para imprimir la partida con sus atributos en formato texto
        public override string ToString()
        {
            return $"Número de partida: {NumPartida} - Puntos: {Puntos}/5";
        }


    }
}
