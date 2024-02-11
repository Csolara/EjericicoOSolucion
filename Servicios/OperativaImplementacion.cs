using EjericicoOSolucion.Dtos;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericicoOSolucion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = crearNuevoCliente();
            listaAntigua.Add(cliente);
            Console.WriteLine(listaAntigua.ToString());
        }

        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("Introduzca su correo electronico (gmail): ");
            nuevoCliente.GmailCliente = Console.ReadLine();

            Console.WriteLine("Introduzca su DNI: ");
            nuevoCliente.DNICliente1 = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("Nombre: " + nuevoCliente.NombreCliente);
            Console.WriteLine("Apellidos: " + nuevoCliente.ApellidosCliente);
            Console.WriteLine("gmail: " + nuevoCliente.GmailCliente);
            Console.WriteLine("DNI: " + nuevoCliente.DNICliente1);
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("");

            return nuevoCliente;
        }

        public void borrarCliente(List<ClienteDto> listaAntigua)
        {
            Console.WriteLine("Escriba el nombre del cliente que quiere borrar: ");
            string NOMBRE = Console.ReadLine();

            ClienteDto borrarCliente = listaAntigua.Find(c => c.NombreCliente == NOMBRE);

            if (borrarCliente != null)
            {
                listaAntigua.Remove(borrarCliente);
                Console.WriteLine("El cliente " + NOMBRE + " se ha eliminado.");
            }
            else
            {
                Console.WriteLine("No se ha encontrado un cliente con el nombre: " + NOMBRE + ".");
            }
        }
    }
}
