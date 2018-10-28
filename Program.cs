using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    class Program
    {
        static void Main(string[] args)
        {



            // creamos un arreglo con las opciones de comidas del menu
            string[] comidas = { "Milanesas           $ 180.-", "Ravioles            $ 200.-", "Sorrentinos         $ 200.-",
                "Pollo               $ 180.-", "Asado               $ 220.-" };
            // creamos un arreglo con las opciones de bebidas del menu
            string[] bebidas = { "Cerveza             $ 100.-", "Vino                $ 200.-", "Gaseosa             $ 50.-", "Agua                $ 50.-",
                "Trago              $ 90.-" };
            // creamos un arreglo con precios
            float[] precio = new float[10];

            precio[0] = 180;// milanesas, pollo
            precio[1] = 200;// ravioles, sorrentinos
            precio[2] = 220;// asado
            precio[3] = 60;// papas
            precio[4] = 50;// gaseosa agua
            precio[5] = 100;// cerveza 
            precio[6] = 200;// vino
            precio[7] = 90;// trago         




            //cantidad de elementos de los arreglos
            byte opcionesDeComidas = Convert.ToByte(comidas.Length), opcionesDeBebidas = Convert.ToByte(bebidas.Length);

            //Mostramos el menu
            Console.WriteLine("MENÚ\n");
            Console.WriteLine("COMIDAS: \n");
            MostrarMenuComida(opcionesDeComidas, comidas);




            Console.WriteLine("");
            Console.WriteLine("\nBEBIDAS: \n");
            MostrarMenuBebida(bebidas);
            Console.WriteLine("");
            Console.WriteLine(Pedido(precio));
            Console.WriteLine(Pedido(precio));




        }//----------------Cierre de Main


        static float Pedido(float[] pedido)
        {
            Console.Write("Ingresar opcion: ");
            byte cliente = Convert.ToByte(Console.ReadLine());
            float opcion = 0;
            switch (cliente)
            {
                case 1:
                    Console.Write("Milanesas: $");
                    opcion = pedido[0]; // milanesa
                    return opcion;

                case 2:
                    Console.Write("Ravioles: $");
                    opcion = pedido[1];//ravioles
                    return opcion;

                case 3:
                    Console.Write("Sorrentinos: $");
                    opcion = pedido[1];//sorrentinos
                    return opcion;

                case 4:
                    Console.Write("Pollo: $");
                    opcion = pedido[0];//pollo
                    return opcion;

                case 5:
                    Console.Write("Asado: $");
                    opcion = pedido[2];//asado
                    return opcion;
                case 6:
                    Console.Write("Cerveza: $");
                    opcion = pedido[5];//cerveza
                    return opcion;
                case 7:
                    Console.Write("Vino: $");
                    opcion = pedido[6];//vino 
                    return opcion;
                case 8:
                    Console.Write("Gaseosa: $");
                    opcion = pedido[4];//gaseosa
                    return opcion;
                case 9:
                    Console.Write("Agua: $");
                    opcion = pedido[4];//agua
                    return opcion;
                case 10:
                    Console.Write("Trago: $");
                    opcion = pedido[7];//trago
                    return opcion;

                default:
                    return 0;

            }
        }//-----------------Cierre Pedido


        static void MostrarMenuComida(byte cantidadElementosDelArreglo, string[] arreglo)
        {
            for (byte i = 1, x = 0; i <= cantidadElementosDelArreglo; i++, x++)
            {
                Console.WriteLine($"{i}. {arreglo[x]}");

            }
        }//-----------------Cierre MostrarMenuComida
        static void MostrarMenuBebida(string[] arreglo)
        {
            for (byte i = 6, x = 0; i <= 10; i++, x++)
            {
                Console.WriteLine($"{i}. {arreglo[x]}");

            }
        }//-----------------Cierre MostrarMenuBebida


    }
}
