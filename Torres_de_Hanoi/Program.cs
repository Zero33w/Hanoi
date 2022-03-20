using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializo las pilas
            Pila ini = new Pila("Inicio");
            Pila fin = new Pila("Final");
            Pila aux = new Pila("Auxiliar");

            //Inicializa un objeto de la clase hanoi
            Hanoi hanoi = new Hanoi();
            bool IoR = false;

            Console.WriteLine("Inserta 1 para el modo Iterarivo o cualquier otro caracter para el modo Recursivo");
            string ir = Console.ReadLine();
            if (ir == "1")
            {
                IoR = true;
            }
            else
            {
                IoR = false;
            }
            //El programa te pide que le des un valor para saber el número de discos que usarás
            Console.WriteLine("Inserta un entero");
            string str = Console.ReadLine();
            int n = int.Parse(str);

            //Segun el valor establecido se añadirán discos en la pila ini
            for (int i = 0; i < n; i++)
            {
                Disco d = new Disco(n - i);
                ini.push(d);
            }

            //Llama a la función que calculará los movimientos necesarios y muestra el resultado en consola

            if (IoR)
            {
                int resI = hanoi.iterativo(n, ini, fin, aux);
                Console.WriteLine("Necesitas mínimo " + resI + " movimientos");
            }
            else
            {
                int resR = hanoi.algoritmo_recursivo(n, ini, fin, aux);
                Console.WriteLine("Necesitas mínimo " + resR + " movimientos");
            }

            //Esto es para que no se cierre la consola sin que te de tiempo a revisar el resultado
            Console.ReadKey();
        }
    }
}
