using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class HabitacionSimple: Habitacion
    {
        public int NumeroCamas { get; set; }

        public override void AtributosEspecificos(int consulta) 
        {
            Console.WriteLine($"Numero de camas {listadoHabitaciones[consulta].NumeroHabitacion} || Precio por noche: {listadoHabitaciones[consulta].PrecioNoche} || Cliente Asignado: {listadoHabitaciones[consulta].ClienteAsignado}");
        }

        public HabitacionSimple(int numeroHabitacion, double precioNoche, string clienteAsignado, int numeroCamas) : base(numeroHabitacion, precioNoche, clienteAsignado)
        {
            NumeroCamas = numeroCamas;
        }

    }
}
