using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame
{
    public class Partida
    {
        public int Puntos { get; set; }
        public int NumPartida { get; set; }
  

        public Partida(int puntos, int numPartida)
        {
            Puntos = puntos;
            NumPartida = numPartida;
 
        }

        public override string ToString()
        {
            return $"Número de partida: {NumPartida} - Puntos: {Puntos}/5";
        }


    }
}
