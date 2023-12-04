using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Dtos
{
    /// <summary>
    /// Clase que contiene toda la informacion necesaria de la vajilla
    /// 04*/12/2023 -> irm
    /// </summary>
    internal class VajillaDto
    {
        //Atributos
        private long idVajilla=0;
        private string codigoElemento = "aaaaa";
        private string nombreElemento="aaaaa";
        private string descripcionElemento = "aaaaa";
        private int cantidadElemento = 0;

        //Getters & Setters
        public long IdVajilla { get => idVajilla; set => idVajilla = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        //Constructores
        public VajillaDto(long idVajilla, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.IdVajilla = idVajilla;
            this.CodigoElemento = codigoElemento;
            this.NombreElemento = nombreElemento;
            this.DescripcionElemento = descripcionElemento;
            this.CantidadElemento = cantidadElemento;
        }
        public VajillaDto() 
        { }

        //Metodo ToString
        override
        public string ToString() 
        {
            string concatenacion ="Nombre:"+ this.nombreElemento + "\n" +"Cantidad del elemento: " + this.cantidadElemento;
            return concatenacion;
        }
    }
}
