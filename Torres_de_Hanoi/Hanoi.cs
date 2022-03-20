using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        //contador de movimientos para recursivo
        int m =0;

        //Si se cumplen unas condiciones mueve un disco entre las dos pilas entrantes y devuelve true, si no se puede no mueve disco y devuelve falso
        public bool mover_disco(Pila a, Pila b)
        {
            // Si hay un disco en la pila origen y no hay disco en le pila destino o el disco de la pila destino es más grande que el de la origen
            if (a.Top != null && (b.Size == 0 || b.Top.getTam() > a.Top.getTam()))
            {
                Console.WriteLine("Se mueve un disco de la pila " +a.Name+ " a la pila " + b.Name);
                Disco d = a.pop();
                b.push(d);
                return true;
            }
            //Si hay un disco en la pila destino y no hay disco en la pila origen o el que hay es más grande que el de la pila destino
            else if (b.Top != null && (a.Size == 0 || a.Top.getTam() > b.Top.getTam()))
            {
                Disco d = b.pop();
                a.push(d);
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
