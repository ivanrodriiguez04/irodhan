using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Interfaz del menu principal de la aplicacion
    /// 04/12/2023 -> irodhan
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal 
        /// y pide la opcion que necesita el usuario
        /// 04/12/2023 -> irodhan
        /// </summary>
        /// <returns>Devuelve la opcion deseada por el usuario</returns>
        public int mostrarMenuYSeleccion();
    }
}
