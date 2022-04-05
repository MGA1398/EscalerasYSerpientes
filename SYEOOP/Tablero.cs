using System;
using System.Collections.Generic;

namespace SYEOOP
{
    public class Tablero
    {
        Dictionary<int, int> eos;
        public Tablero(Dictionary<int, int> eos)
        {
            this.eos = eos;
        }

        public int buscar(int pos)
        {
            int sig;
            if (eos.ContainsKey(pos))
            {
                sig = eos[pos];
                if (pos < sig)
                {
                    Console.WriteLine("Encontraste en un escalera, subes a la posicion {0}.", sig);
                    if (sig == 100) return 100;
                    return sig;
                }
                else if (pos > sig)
                {
                    Console.WriteLine("Pisaste una serpiente, bajas a la posicion {0}.", sig);
                    return sig;
                }
            }
            return pos;
        }
    }
}
