using irodhan.Dtos;
using irodhan.Servicios;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace irodhan
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 04/12/2023 -> irodhan
    /// </summary>
    class Program 
    { 
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 04/12/2023 -> irodhan
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            //Creamos los objetos necesarios
            MenuInterfaz mI = new MenuImplementacion();
            ModificacionesListaInterfaz mL = new ModificacionesListaImplementacion(); 
            //Creamos las listas nacesarias
            List<VajillaDto> listaVajilla = new List<VajillaDto> ();
            //Creamos las variables necesarias
            bool cerrarMenu=false;
            int opcionSeleccionada = 0;

            //Comenzamos un bucle while
            while(!cerrarMenu) 
            {
                //Guardamos el valor del metodo en la variable creada
                opcionSeleccionada=mI.mostrarMenuYSeleccion();
                //Creamos un switch a traves de opcionSeleccionada
                switch (opcionSeleccionada)
                { 
                    case 0:
                        Console.WriteLine("[INFO] - Ha seleccionada la opcion cerrar app");
                        cerrarMenu=true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionada la opcion dar de alta un nuevo elemento");
                        mL.darAltaVajilla(listaVajilla);
                        foreach (VajillaDto vajilla in listaVajilla)
                        {
                            Console.WriteLine(vajilla.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionada la opcion modificar cantidad");
                        mL.darBajaVajilla(listaVajilla);
                        foreach (VajillaDto vajilla in listaVajilla)
                        {
                            Console.WriteLine(vajilla.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincida con ninguna");
                        break;
                }
            }
        }
    }
}
