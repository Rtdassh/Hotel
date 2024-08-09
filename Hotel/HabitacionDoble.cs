using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class HabitacionDoble: Habitacion
    {
        public bool VistaAlMar { get; set; }

        public override void AtributosEspecificos()
        {
            string option;
            if (VistaAlMar == true) option = "Afirmativo";
            else option = "Negativo";
            Console.WriteLine($"Vista al mar: {option}");
        }
        public HabitacionDoble(int numeroHabitacion, double precioNoche, string clienteAsignado, bool vistaAlMar) : base(numeroHabitacion, precioNoche, clienteAsignado)
        {
            VistaAlMar = vistaAlMar;
        }


    }
}
