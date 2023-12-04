using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Clase que implementa la a interfaz de las modificaciones
    /// 04/12/2023 -> irodhan
    /// </summary>
    internal class ModificacionesListaImplementacion : ModificacionesListaInterfaz
    {
        public void darAltaVajilla(List<VajillaDto> ListaVajillaAntigua)
        {
            VajillaDto nuevaVajilla = crearVajilla();
            ListaVajillaAntigua.Add(nuevaVajilla);
        }
        /// <summary>
        /// Metodo que pide al usuario toda la informacion necesaria de la vajilla
        /// 04/12/2023 -> irodhan
        /// </summary>
        /// <returns>Devuelve un objeto con toda la informacion necesaria</returns>
        private VajillaDto crearVajilla() 
        {
            //Creamos un objeto para poder acceder a los campos
            VajillaDto vajilla = new VajillaDto();
            //Pedimos al usuario toda la informacion necesaria
            Console.WriteLine("Introduzca el id de la vajilla: ");
            vajilla.IdVajilla = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre de la vajilla: ");
            vajilla.NombreElemento = Console.ReadLine();
            vajilla.CodigoElemento = vajilla.IdVajilla + vajilla.NombreElemento;
            Console.WriteLine("Introduzca la descripcion del elemento: ");
            vajilla.DescripcionElemento = Console.ReadLine();
            Console.WriteLine("Introduzca la cantidad del elemento:");
            vajilla.CantidadElemento = Convert.ToInt32(Console.ReadLine());
            //Devuelve el objeto creado para poder añadirlo a la lista
            return vajilla;
        }

        public void darBajaVajilla(List<VajillaDto> ListaVajillaAntigua)
        {
            int cantidad;
            string codigo = pedirCodigoElemento();
            foreach (VajillaDto vajilla in ListaVajillaAntigua) 
            {
                if (vajilla.CodigoElemento.Equals(codigo))
                {
                    Console.WriteLine("Introduzca el numero a bajar de la cantidad del producto:");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    vajilla.CantidadElemento = vajilla.CantidadElemento - cantidad;
                }
                else 
                {
                    Console.WriteLine("[INFO] - El codigo elemento introducido no existe");
                }
            }
        }

        /// <summary>
        /// Metodo que pide al usuario cual es el codigo elemento a modifica
        /// 04/12/2023 -> irodhan
        /// </summary>
        /// <returns>Devuelve el codigo pedido al usuario</returns>
        private string pedirCodigoElemento() 
        {
            string codigo;
            Console.WriteLine("Introduzca el codigo elemento del elemento a modificar: ");
            codigo= Console.ReadLine();
            return codigo;
        }
    }
}
