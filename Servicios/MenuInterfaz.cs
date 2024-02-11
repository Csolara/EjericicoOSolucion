using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericicoOSolucion.Servicios
{
    /// <summary>
    /// Interfaz que se encarga del menu de la aplicacion.
    /// CSL - 090224
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que solicita por pantalla una opcion y la recoge.
        /// </summary>
        /// <returns></returns>
        public int MENU();

    }
}
