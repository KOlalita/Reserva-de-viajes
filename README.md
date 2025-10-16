# Reserva de viajes


SOLID2/
│
├── Program.cs              # Archivo principal de la aplicación
│
├── Clases principales:
│   ├── MenuAPP             # Maneja el menú y las opciones del usuario
│   ├── Personal            # Representa a la persona que viaja
│   ├── Viaje               # Representa la información de cada viaje
│   ├── IReservable         # Interfaz que define el comportamiento de una reserva
│   ├── ReservaBus          # Implementa la reserva en bus
│   ├── ReservaAvion        # Implementa la reserva en avión
│   └── GestorDeReservas    # Administra todas las reservas realizadas




Menú principal:

 SISTEMA DE RESERVAS DE VIAJE 
1. Reservar viaje en bus
2. Reservar viaje en avión
3. Mostrar reservas
4. Salir
Seleccione una opción:



Reserva en Bus

Seleccionar la opción 1.
El sistema solicitará destino, fecha, costo, nombre, DNI y cargo del pasajero.
Ejemplo:

Ingrese destino: Lima
Ingrese fecha: 20/10/2025
Ingrese costo: 80
Nombre pasajero: Juan Pérez
DNI: 12345678
Cargo: Estudiante
Reserva en bus realizada correctamente.




Reserva en Avión

Seleccionar la opción 2.
El procedimiento es el mismo que en bus, pero con transporte “Avión”.

Ingrese destino: Madrid
Ingrese fecha: 21/10/2025
Ingrese costo: 250
Nombre pasajero: Ana Torres
DNI: 87654321
Cargo: Ejecutiva
Reserva de avión realizada correctamente.




Mostrar Reservas

Seleccionar la opción 3.
El sistema mostrará todas las reservas registradas:

--- RESERVAS REGISTRADAS ---
Destino: Lima, Fecha: 20/10/2025, Transporte: Bus, Costo: 80 - Pasajero: Juan Pérez (Estudiante) - DNI: 12345678
Destino: Madrid, Fecha: 21/10/2025, Transporte: Avión, Costo: 250 - Pasajero: Ana Torres (Ejecutiva) - DNI: 87654321






Seleccionar la opción 4 para finalizar la aplicación.

Seleccione una opción: 4


