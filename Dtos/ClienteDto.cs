using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericicoOSolucion.Dtos
{
    internal class ClienteDto
    {

        string nombreCliente = "aaaaa";

        string apellidosCliente = "aaaaa";

        string gmailCliente = "aaaaa";

        string DNICliente = "aaaaa";
        
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string GmailCliente { get => gmailCliente; set => gmailCliente = value; }
        public string DNICliente1 { get => DNICliente; set => DNICliente = value; }

        public ClienteDto(string nombreCliente, string apellidosCliente, string gmailCliente, string dNICliente)
        {
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.gmailCliente = gmailCliente;
            DNICliente = dNICliente;
        }

        public ClienteDto()
        {

        }

        public string ToString()
        {
            string cliente = "nombreCliente: " + this.nombreCliente +
                "apellidiosCliente: " + this.apellidosCliente +
                "gmailCliente: " + this.gmailCliente +
                "DNI: " + this.DNICliente;
            return cliente;
        }        
    }
}
