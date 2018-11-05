using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpEstructura
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList menu = new SortedList(); // ------------Creamos un Diccionario con los elementos del menu
            menu.Add("MILANESA", 180.0f);
            menu.Add("POLLO", 180.0f);
            menu.Add("RAVIOLES", 200.0f);
            menu.Add("SORRENTINOS", 200.0f);
            menu.Add("ASADO", 220.0f);
            menu.Add("GASEOSA", 50.0f);
            menu.Add("AGUA", 50.0f);
            menu.Add("CERVEZA", 100.0f);
            menu.Add("VINO", 200.0f);
            menu.Add("TRAGO", 90.0f);

            ArrayList factura = new ArrayList();   // -------- creamos una lista para almacenar la seleccion de alimentos
            ArrayList montos = new ArrayList();    // -------- creamos otra lista para almacenar los valores de los precios

            Console.WriteLine("\n***********************PEDIDO***********************" +
                            "\n\nINGRESE EL NúMERO DE LA OPCIÓN QUE DESEA AGREGAR : "); 
            MostrarMenu(menu);  // --------------------------- MUESTRA LAS OPCIONES DE MENU - RECORRIENDO UN DICCIONARIO
            string pedido = Pedido(PedirOpcion()); // -------- PIDE UNA OPCION AL USUARIO Y LA GUARDA EN LA VARIABLE PEDIDO 
            factura.Add(pedido); // -------------------------- LA OPCION DEL USUARIO SE GUARDA EN UNA LISTA (LA CLAVE DE DICCIONARIO EJEMPLO "MILANESA")
            float precio = Convert.ToSingle(menu[pedido]);// - GUARDAMOS EL VALOR DE LA CLAVE DEL DICCIONARIO (EL PRECIO ) QUE ELIJIO EL USUARIO
            montos.Add(precio);// ---------------------------- EL PRECIO SE GUARDA EN OTRA LISTA
            
            Limpiar(); // -- limpia la consola
            float cuenta = precio;

            bool fin = true;


            ImprimirOpciones();
            while(fin == true)

            {
                
                string opciones = Opciones(PedirOpcion());
                Limpiar();
                
                if (opciones == "AGREGAR")  
                {
                    Limpiar();
                    Console.WriteLine("\nAgregar una opción al pedido\n"); 
                    MostrarMenu(menu);//------------------------- SE MUESTRAN LAS OPCIONES DEL MENU
                    pedido = Pedido(PedirOpcion());
                    precio = Convert.ToSingle(menu[pedido]);
                    factura.Add(pedido);// ------------------------ SE AGREGA A LA LISTA FACTURA - LA OPCION SELECCIONADA
                    int indice = factura.IndexOf(pedido);
                    montos.Add(precio);//-------------------------- SE AGREGA A LA LISTA MONTOS - EL PRECIO DE LA OPCION SELECCIONADA
                    cuenta = Agregar(cuenta, precio);//------------ SE LE SUMA EL PRECIO A LA VARIABLE CUENTA
                    
                }
                else if (opciones == "QUITAR")
                {
                    Limpiar();
                    
                    
                    Console.WriteLine("\nQuitar una opción al pedido\n");
                    MostrarPedidoParcial(factura); // MUESTRA LO AGREGADO EN LA LISTA DE COMIAS
                    Console.WriteLine("");
                    int opcionEliminar = Convert.ToInt32(Console.ReadLine()); // PIDE OPCION AL USUARIO
                    float descontar = Convert.ToSingle(montos[opcionEliminar]); 
                    factura.RemoveAt(opcionEliminar); // ELIMINA LA OPCION DE LA LISTA DE COMIDAS/BEBIDAS QUE INGRESO EL USUARIO
                    montos.RemoveAt(opcionEliminar); // ELIMINA LA OPCION DE LA LISTA DE PRECIOS QUE INGRESO EL USUARIO
                    cuenta = Quitar(cuenta, descontar);  // SE LE RESTA EL PRECIO DE LA OPCION ELIMINADA A LA VARIABLE CUENTA
                    
                }
                else if (opciones == "MOSTRAR PEDIDO")
                {
                    Limpiar();

                    MostrarPedidoParcial(factura);




                }
                else if(opciones == "SUBTOTAL")
                {
                    Console.WriteLine($"\nSUBTOTAL : ${cuenta}");
                                       

                }
                else if (opciones == "DESCUENTO")
                {
                    cuenta = Descuento(ref cuenta);


                }
                else if(opciones == "IMPRIMIR CUENTA")
                {
                    Console.WriteLine("\n\n****************DETALLE****************\n");
                    ImprimirFactura(factura,montos);
                    Console.WriteLine("\nTOTAL ..............$ {0}.-\n\n\n",cuenta);
                    
                    fin = false;
                    if (fin == false) { break; }
                }
                
                Console.WriteLine("");
                ImprimirOpciones();
                

            }

            


        }//-----------------------------------------------------------------------------------------Main

               
        static int PedirOpcion()
        {
            Console.WriteLine("");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }//-----------------------------------------------------------------------------------------PedirOpcion

        
        static float Descuento(ref float valor)
        {
            Console.Write("Ingresar porcentaje de descuento :   %  ");
            float porcentaje = Convert.ToSingle(Console.ReadLine());
            porcentaje = porcentaje / 100;
            float resultado = valor * porcentaje;
            float valorFinal = valor - resultado;
            return valorFinal;

            
        }//-----------------------------------------------------------------------------------------Descuento


        static void MostrarMenu(SortedList diccionario) // Recorre el diccionario con un for
        {
            Console.WriteLine("");
            for (int i = 0, x = 1; i < diccionario.Count; i++, x++) { Console.WriteLine("{1}. {0}", diccionario.GetKey(i), x); }
        }//------------------------------------------------------------------------------------------MostrarMenu


        static string Pedido(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return "AGUA";
                case 2:
                    return "ASADO";
                case 3:
                    return "CERVEZA";
                case 4:
                    return "GASEOSA";
                case 5:
                    return "MILANESA";
                case 6:
                    return "POLLO";
                case 7:
                    return "RAVIOLES";
                case 8:
                    return "SORRENTINOS";
                case 9:
                    return "TRAGO";
                case 10:
                    return "VINO";
                default:
                    return "ERROR";

            }
        }//--------------------------------------------------------------------------------------------Pedido

        static void ImprimirOpciones()
        {
            Console.WriteLine("\n1. AGREGAR\n2. QUITAR\n3. MOSTRAR PEDIDO\n4. SUBTOTAL\n5. DESCUENTO\n6. IMPRIMIR CUENTA");
        }


        static string Opciones(int opcion)
        {
            

            switch (opcion)
            {
                case 1:
                    return "AGREGAR";
                case 2:
                    return "QUITAR";
                case 3:
                    return "MOSTRAR PEDIDO";
                case 4:
                    return "SUBTOTAL";
                case 5:
                    return "DESCUENTO";
                case 6:
                    return "IMPRIMIR CUENTA";
                
                default:
                    return "ERROR";

            }
        }//--------------------------------------------------------------------------------------------Opciones


            static float Agregar(float valor1, float valor2)
        {
            return valor1 + valor2;
        }//---------------------------------------------------------------------------------------------Agregar




        static float Quitar(float valor1, float valor2)
        {
            return valor1 - valor2;
        }//---------------------------------------------------------------------------------------------Quitar

        static void Limpiar()
        {
            Console.Clear();
        }//-----------------------------------------------------------------------------------------------Limpiar
        static void MostrarPedidoParcial(ArrayList factura)
        {
            for (byte i = 0; i < Convert.ToByte(factura.Count); i++)
            {
                
                Console.WriteLine("{1}. {0}", factura[i], factura.IndexOf(factura[i]));

            }

        }//-----------------------------------------------------------------------------------------------MostrarPedidoParcial


        static void ImprimirFactura(ArrayList factura, ArrayList montos)
        {
            for (byte i = 0,  x = 0; i < Convert.ToByte(montos.Count); i++, x++)
            {
                
                Console.WriteLine("{0} ............$ {1}.-",Convert.ToString(factura[i]),Convert.ToSingle(montos[x]));
                
            }
            


        }//--------------------------------------------------------------------------------------------ImprimirFactura
        

        


      
    }
}
