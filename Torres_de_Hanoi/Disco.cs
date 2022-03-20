using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        //Establece el tamaño del disco
        private int Tam;

        //Constructor del disco
        public Disco(int x)
        {
            this.Tam = x;
        }

        //Devuelve el tamaño del disco
        public int getTam() { return this.Tam; }
    }
}
