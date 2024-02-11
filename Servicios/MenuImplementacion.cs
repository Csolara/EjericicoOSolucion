using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericicoOSolucion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int MENU()
        {
            int opcionseleccionada;

            Console.WriteLine("########################");
            Console.WriteLine("0. Cerrar menu.");
            Console.WriteLine("1. Crear nuevo cliente.");
            Console.WriteLine("2. Borrar cliente.");            
            Console.WriteLine("########################");

            opcionseleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionseleccionada;
        }

    }
}
