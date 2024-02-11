using EjericicoOSolucion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericicoOSolucion.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de la operativa de la aplicacion.
    /// CSL - 090224
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de crear y guardar los datos de un cliente.
        /// CSL - 090224
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<ClienteDto> listaAntigua);

        /// <summary>
        /// Metodo que se encarga de borrar los datos de un cliente existente.
        /// CSL - 090224
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void borrarCliente(List<ClienteDto> listaAntigua);        
    }
}
