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

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int res = 0;

            if (n % 2 != 0)//Si el numero de discos inicial es impar
            {
                while (fin.Size < n) //Mientras no hayan llegado todos los discos a la pila final
                {
                    if (mover_disco(ini, fin)) res++; //Si se puede mover el disco se suma 1 al contador de movimientos
                    if (fin.Size == n) break; //Si fin ya tiene todos los discos, para

                    if (mover_disco(ini, aux)) res++;

                    if (mover_disco(aux, fin)) res++;
                }
            }
            else //Si lo es
            {
                while (fin.Size < n)
                {
                    if (mover_disco(ini, aux)) res++;

                    if (mover_disco(ini, fin)) res++;
                    if (fin.Size == n) break;

                    if (mover_disco(aux, fin)) res++;
                }
            }
            return res;
        }
        public int algoritmo_recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            if (n == 1)
            {
                if (mover_disco(ini, fin)) m++;
            }
            else
            {
                algoritmo_recursivo(n - 1, ini, aux, fin);
                if (mover_disco(ini, fin)) m++;
                algoritmo_recursivo(n - 1, aux, fin, ini);
            }
            return m;
        }
    }
}
