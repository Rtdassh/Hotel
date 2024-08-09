using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Suite: Habitacion
    {
        public override void AtributosEspecificos()
        {
            Console.WriteLine($"Jacuzzi: {Jacuzzi} || Numero de habitaciones: {NumeroHabitaciones}");
        }
        public Suite(int numeroHabitacion, double precioNoche, string clienteAsignado, bool jacuzzi, int numeroHabitaciones) : base(numeroHabitacion, precioNoche, clienteAsignado)
        {
            Jacuzzi = jacuzzi;
            NumeroHabitaciones = numeroHabitaciones;
        }

        public bool Jacuzzi { get; set; }
        public int NumeroHabitaciones { get; set; }



    }
}
