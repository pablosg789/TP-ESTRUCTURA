using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace clase_pila
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            Stack miPila = new Stack();
            miPila.Push("Hola, ");
            miPila.Push("soy, ");
            miPila.Push("yo, ");
            
            for (byte i = 0; i < 3; i++)
            {
                palabra = (string)miPila.Pop();
                Console.WriteLine(palabra);
                
            }
            
        }
    }
}
