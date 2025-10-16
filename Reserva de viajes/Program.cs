using System;
using System.Collections.Generic;

namespace SOLID2
{
    internal class Program
    {
        // Menu
        public class MenuAPP
        {
            private GestorDeReservas gestor = new GestorDeReservas();

            public void Iniciar()
            {
                while (true)
                {
                    Console.WriteLine("\n--- SISTEMA DE RESERVAS DE VIAJE ---");
                    Console.WriteLine("1. Reservar viaje en bus");
                    Console.WriteLine("2. Reservar viaje en avión");
                    Console.WriteLine("3. Mostrar reservas");
                    Console.WriteLine("4. Salir");
                    Console.Write("Seleccione una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            gestor.AgregarReserva(new ReservaBus());
                            break;
                        case "2":
                            gestor.AgregarReserva(new ReservaAvion());
                            break;
                        case "3":
                            gestor.MostrarReservas();
                            break;
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
            }
        }

        // Personal
        class Personal
        {
            public string Nombre { get; set; }
            public int DNI { get; set; }
            public string Cargo { get; set; }

            public Personal(string nombre, int dNI, string cargo)
            {
                this.Nombre = nombre;
                this.DNI = dNI;
                this.Cargo = cargo;
            }

            public override string ToString()
            {
                return $"{Nombre} ({Cargo}) - DNI: {DNI}";
            }
        }

        // Viaje
        class Viaje
        {
            public string Destino { get; set; }
            public double Costo { get; set; }
            public Personal Pasajero { get; set; }
            public string Transporte { get; set; }
            public string Fecha { get; set; }

            public override string ToString()
            {
                return $"Destino: {Destino}, Fecha: {Fecha}, Transporte: {Transporte}, Costo: {Costo} - Pasajero: {Pasajero}";
            }
        }

        // Interfaz
        interface IReservable
        {
            void Reservar();
            Viaje ObtenerViaje();
        }

        // Reservar 
        class ReservaBus : IReservable
        {
            private Viaje viaje;

            public void Reservar()
            {
                viaje = new Viaje();
                viaje.Transporte = "Bus";
                Console.Write("Ingrese destino: ");
                viaje.Destino = Console.ReadLine();
                Console.Write("Ingrese fecha: ");
                viaje.Fecha = Console.ReadLine();
                Console.Write("Ingrese costo: ");
                viaje.Costo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nombre pasajero: ");
                string nombre = Console.ReadLine();
                Console.Write("DNI: ");
                int dni = int.Parse(Console.ReadLine());
                Console.Write("Cargo: ");
                string cargo = Console.ReadLine();

                viaje.Pasajero = new Personal(nombre, dni, cargo);

                Console.WriteLine("Reserva en bus realizada correctamente.");
            }

            public Viaje ObtenerViaje() => viaje;
        }

        // Reservar 
        class ReservaAvion : IReservable
        {
            private Viaje viaje;

            public void Reservar()
            {
                viaje = new Viaje();
                viaje.Transporte = "Avión";
                Console.Write("Ingrese destino: ");
                viaje.Destino = Console.ReadLine();
                Console.Write("Ingrese fecha: ");
                viaje.Fecha = Console.ReadLine();
                Console.Write("Ingrese costo: ");
                viaje.Costo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nombre pasajero: ");
                string nombre = Console.ReadLine();
                Console.Write("DNI: ");
                int dni = int.Parse(Console.ReadLine());
                Console.Write("Cargo: ");
                string cargo = Console.ReadLine();

                viaje.Pasajero = new Personal(nombre, dni, cargo);

                Console.WriteLine("Reserva de avión realizada correctamente.");
            }

            public Viaje ObtenerViaje() => viaje;
        }

        // Gestor de reservas
        class GestorDeReservas
        {
            private List<IReservable> reservas = new List<IReservable>();

            public void AgregarReserva(IReservable reserva)
            {
                reserva.Reservar();
                reservas.Add(reserva);
            }

            public void MostrarReservas()
            {
                Console.WriteLine("\n--- RESERVAS REGISTRADAS ---");
                if (reservas.Count == 0)
                {
                    Console.WriteLine("No hay reservas registradas.");
                    return;
                }

                foreach (var r in reservas)
                {
                    Console.WriteLine(r.ObtenerViaje());
                }
            }
        }





        static void Main(string[] args)
        {
            MenuAPP menu = new MenuAPP();
            menu.Iniciar();

        }
    }
}
