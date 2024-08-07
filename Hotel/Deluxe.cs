using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Deluxe: Habitacion
    {
        public Deluxe(int numeroHabitacion, double precioNoche, string clienteAsignado, string serviciosAdicionales) : base(numeroHabitacion, precioNoche, clienteAsignado)
        {
            ServiciosAdicionales = serviciosAdicionales;
        }

        public string ServiciosAdicionales { get; set; }
    }
}
