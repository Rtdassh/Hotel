using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel
{
    internal class Habitacion
    {
        public static List<Habitacion> listadoHabitaciones = new List<Habitacion>();
        public int NumeroHabitacion { get; set; }
        public double PrecioNoche { get; set; }
        public string ClienteAsignado { get; set; }
        

        public static void AgregarHabitacion()
        {
            Console.WriteLine("Ingrese el tipo de habitación que ingresará");
            Console.WriteLine("1. Habitación Simple");
            Console.WriteLine("2. Habitación Doble");
            Console.WriteLine("3. Suite");
            Console.WriteLine("4. Habitación Deluxe");
            int tipoHabitacion = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el numero de habitación: ");
            int numeroHabitacion = default;
            bool numeroRepetido = true;

            while (numeroRepetido)
            {
                while (!int.TryParse(Console.ReadLine(), out numeroHabitacion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido para la habitación. ");
                }

                Habitacion? consulta = listadoHabitaciones.Find(n => n.NumeroHabitacion == numeroHabitacion);
                if (consulta == null) { Console.WriteLine("Enhorabuena, el numero de habitación es nuevo"); break; }
                else { Console.WriteLine("Desgraciadamente, el numero de habitación se repite"); Console.ReadKey(); }
            }
                Console.Write("Ingrese el precio por noche: ");
                double precio = Convert.ToDouble(Console.ReadLine() ?? "");

                switch (tipoHabitacion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el numero de camas");
                        int numeroCamas = Convert.ToInt32(Console.ReadLine() ?? "");

                        HabitacionSimple habitacionSimpleAgregada = new HabitacionSimple(numeroHabitacion, precio, "N/A", numeroCamas);
                        listadoHabitaciones.Add(habitacionSimpleAgregada);
                        break;
                    case 2:
                        Console.WriteLine("¿Posee vista al mar?, escriba si o no");
                        string vistaMar = Console.ReadLine() ?? "";
                        HabitacionDoble habitacionDobleAgregada = new HabitacionDoble(numeroHabitacion, precio, "N/A", Comparacion(vistaMar));
                        listadoHabitaciones.Add(habitacionDobleAgregada);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el numero de habitaciones");
                        int numeroHabitaciones = Convert.ToInt32(Console.ReadLine() ?? "");
                        Console.WriteLine("¿Tiene Jacuzzi?, escriba si o no");
                        string jacuzzi = Console.ReadLine() ?? "";
                        bool Jacuzzi = Comparacion(jacuzzi);

                        Suite SuiteAgregada = new Suite(numeroHabitacion, precio, "N/A", Jacuzzi, numeroHabitaciones);
                        listadoHabitaciones.Add(SuiteAgregada);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el numero de camas");
                        string extras = Console.ReadLine() ?? "";

                        Deluxe DeluxeAgregada = new Deluxe(numeroHabitacion, precio, "N/A", extras);
                        listadoHabitaciones.Add(DeluxeAgregada);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("¡Tu habitación se ha ingresado con éxito!");            
        }

            public static bool Comparacion(string cadenaTexto)
            {
                int comparacion = string.Compare(cadenaTexto, "si", true);
                if (comparacion == 0) return true;
                else return false;
            }
            public static void EliminarHabitacion()
            {
                int consulta = Busqueda();
                if (consulta != -1) listadoHabitaciones.Remove(listadoHabitaciones[consulta]);
            }
            public virtual void MostrarInfo()
            {
            int consulta = Busqueda();
            if (consulta != -1) {
                Console.WriteLine($"Numero de habitación: {listadoHabitaciones[consulta].NumeroHabitacion} || Precio por noche: {listadoHabitaciones[consulta].PrecioNoche} || Cliente Asignado: {listadoHabitaciones[consulta].ClienteAsignado}");
                AtributosEspecificos(consulta);
            }
            else Console.WriteLine("Desgraciadamente, el numero de habitación no se ha encontrado");
        }

        public virtual void AtributosEspecificos(int consulta) { }

            public static int Busqueda()
            {
                Console.WriteLine("Ingrese el numero de habitación");
                int numeroHabitacion = Convert.ToInt32(Console.ReadLine());

               int consulta = listadoHabitaciones.FindIndex(n => n.NumeroHabitacion == numeroHabitacion);
                if (consulta >=0) return consulta;
                else return -1; 
            }
            public static void CambiarDisponibilidad(bool disponible)
            {

            }

            public static void AsignarCliente(string nombreCliente)
            {
                int consulta = Busqueda();

            if (consulta != -1 && listadoHabitaciones[consulta].ClienteAsignado != "N/A" )
                {
                Console.WriteLine("Ingrese el nombre del cliente");
                string nombre = Console.ReadLine()??"";
                listadoHabitaciones[consulta].ClienteAsignado = nombre;
                }
                else
                {
                    Console.WriteLine("No se ha encontrado dicha habitación");
                }
            }

            public static void LiberarHabitacion()
            {

            }



            public Habitacion(int numeroHabitacion, double precioNoche, string clienteAsignado)
            {
                NumeroHabitacion = numeroHabitacion;
                PrecioNoche = precioNoche;
                ClienteAsignado = clienteAsignado;
            }
        }
    }
