using System;
namespace SYEOOP
{
    public class Jugador
    {
        int posicion;

        public Jugador()
        {
            this.posicion = 1;
        }

        public Jugador(int posicion)
        {
            this.posicion = posicion;
        }

        public int tiro()
        {
            Random rand = new Random();
            Console.WriteLine("Presione spacebar para lanzar el dado");
            ConsoleKey Key = Console.ReadKey(true).Key;
            while (Key != ConsoleKey.Spacebar)
            {
                Console.WriteLine("Presione spacebar para lanzar el dado");
                Key = Console.ReadKey(true).Key;
            }
            int dado = rand.Next(1, 6);
            Console.Write("Desde la posicion {0} lanzas un {1}", posicion, dado);
            if (posicion + dado > 100)
            {
                Console.WriteLine(" pero no puedes avanzar");
                return posicion;
            }
            else
            {
                int sig = posicion + dado;
                Console.WriteLine(" y avanzas a la casilla {0}", sig);
                return sig;
            }
        }

        public int movimiento(int newpos)
        {
            if (newpos == 100)
            {
                return 100;
            }
            else return this.posicion = newpos;
        }
    }
}