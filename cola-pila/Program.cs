using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // se debe ingresar para que funcion COLA y PILA

namespace practica_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = {1, 2, 3, 4};

            Console.WriteLine("***COLA***");
            Queue colaEjemplo = new Queue();
            
            for (byte i = 1, x = 0; i <= 4; i++ , x++)
            {
                colaEjemplo.Enqueue(n[x]);

                                          
            }
            Console.WriteLine(colaEjemplo.Contains(8));
            Console.WriteLine(colaEjemplo.GetType());
            


            for (byte i = 1, x = 0; i <= 4; i++, x++)
            {
                int numero = (int)colaEjemplo.Dequeue();
                Console.WriteLine(numero);
                //Console.WriteLine(colaEjemplo.Dequeue());

            }
            Console.WriteLine("\n***PILA***");
            Stack pilaEjemplo = new Stack();

            for (byte i = 1, x = 0; i <= 4; i++, x++)
            {
                pilaEjemplo.Push(n[x]);
                
            }
            

            for (byte i = 1, x = 0; i <= 4; i++, x++)
            {
                int numero = (int)pilaEjemplo.Pop();
                Console.WriteLine(numero);
            }


            
