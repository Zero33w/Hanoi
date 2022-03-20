using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        //Devuelve el tamaño de la pila
        public int Size { get { return Elementos.Count; } }
        public string Name="";
        //Devuelve el disco de más arriba de la pila, en caso de no haber devuelve null
        public Disco Top
        {
            get
            {
                if (isEmpty() != true)
                {
                    return Elementos[Size - 1];
                }
                else
                {
                    return null;
                }
            }
        }

        //Declara una lista discos
        public List<Disco> Elementos = new List<Disco>();

        public Pila(string str) {
            Name = str;
        }

        //Permite añadir un disco al final de la lista de discos
        public void push(Disco d)
        {
            Elementos.Add(d);
        }

        //Permite eliminar un disco al final de la lista de discos y devuelve el anterior disco en la cima
        public Disco pop()
        {
            Disco exTop = Top;
            Elementos.Remove(Top);

            return exTop;
        }

        //Comprueba si la pila está vacía
        public bool isEmpty()
        {
            if (this.Size == 0)
            {
                return true;
            }
            return false;
        }
    }
}
