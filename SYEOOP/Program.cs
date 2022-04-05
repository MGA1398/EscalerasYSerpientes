using System;
using System.Collections.Generic;

namespace SYEOOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<int, int> eos = new Dictionary<int, int>() {
            {2, 38},
            {16, 6},
            {7, 14},
            {8, 31},
            {49, 11},
            {15, 26},
            {62, 19},
            {21, 42},
            {46, 25},
            {28, 84},
            {36, 44},
            {51, 67},
            {89, 68},
            {64, 60},
            {71, 91},
            {92, 88},
            {87, 94},
            {74, 53},
            {95, 75},
            {99, 80},
            };
            Tablero tablero = new Tablero(eos);
            List<Jugador> jugadores = new List<Jugador>();
            Console.WriteLine("Ingrese la cantidad de jugadores que desea.");
            int n = Convert.ToInt32(Console.ReadLine());
            int ganador = 0;
            for (int i = 0; i < n; i++)
            {
                jugadores.Add(new Jugador());
            }
            while (ganador != 100)
            {
                for(int i = 0; i < n; i++)
                {
                    Jugador turno = jugadores[i];
                    Console.WriteLine("Jugador {0} es tu turno!", i+1);
                    int pos = turno.tiro();
                    int newpos = tablero.buscar(pos);
                    ganador = turno.movimiento(newpos);
                    if(ganador == 100)
                    {
                        Console.WriteLine("Felicidades jugador {0}! haz ganado!", i+1);
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
