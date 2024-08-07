﻿using System;
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
            int numeroHabitacion = Convert.ToInt32(Console.ReadLine());

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
                    string vistaMar = Console.ReadLine()??"";
                    int validacionVistaMar = String.

                    HabitacionSimple habitacionSimpleAgregada = new HabitacionSimple(numeroHabitacion, precio, "N/A", numeroCamas);
                    listadoHabitaciones.Add(habitacionSimpleAgregada);
                    break;
                case 3:
                   
                    break;
                default:
                    break;
            }
            Console.WriteLine("¡Tu producto se ha ingresado con éxito!");
        }
        
        public static void MostrarInfo() 
        {
           
        }

        public static void CambiarDisponibilidad(bool disponible)
        {

        }

        public static void AsignarCliente(string nombreCliente)
        {

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
