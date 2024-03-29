﻿using EjericicoOSolucion.Dtos;
using EjericicoOSolucion.Servicios;

namespace EjericicoOSolucion.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion.
    /// CSL - 090224
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo principal de la aplicacion.
        /// CSL - 090224
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            List<ClienteDto> listaClientes = new List<ClienteDto>();

            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            bool cerrarMenu = false;

            while(!cerrarMenu)
            {
                int recogido = mi.MENU();
                switch(recogido)
                {
                    case 0:
                        Console.WriteLine("La aplicacion se cerrara.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        oi.darAltaCliente(listaClientes);
                        break;
                    case 2:
                        oi.borrarCliente(listaClientes);
                        break;                    
                    default:
                        Console.WriteLine("La opcion que ha seleccionado no coincide con ninguna");
                        break;
                }
            }

        }
    }
}