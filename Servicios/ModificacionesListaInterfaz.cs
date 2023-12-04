using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Interfaz de las modificaciones a las listas
    /// 04/12/2023 -> irodhan
    /// </summary>
    internal interface ModificacionesListaInterfaz
    {
        /// <summary>
        /// Metodo que añade un nuevo objeto a la lista
        /// 04/12/2023 -> irodhan
        /// </summary>
        /// <param name="ListaVajillaAntigua"></param>
        public void darAltaVajilla(List<VajillaDto> ListaVajillaAntigua);
        /// <summary>
        /// Metodo que modifica en la lista la cantidad de la vajilla
        /// </summary>
        /// <param name="ListaVajillaAntigua"></param>
        public void darBajaVajilla(List<VajillaDto> ListaVajillaAntigua);
    }
}
