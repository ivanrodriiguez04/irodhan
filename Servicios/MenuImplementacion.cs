using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{/// <summary>
/// Clase que implementa a la interfaz del menu
/// 04/12/2023 -> irodhan
/// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion=0;
            Console.WriteLine("0. Cerrar App");
            Console.WriteLine("1. Dar alta nuevo elemento");
            Console.WriteLine("2. Dar de baja cantidad de algun elemento");
            opcion=Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
