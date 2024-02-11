using EjericicoOSolucion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericicoOSolucion.Servicios
{
    internal interface OperativaInterfaz
    {

        public void darAltaCliente(List<ClienteDto> listaAntigua);

        public void borrarCliente(List<ClienteDto> listaAntigua);        
    }
}
