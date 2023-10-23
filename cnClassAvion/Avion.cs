using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Avion
{
    public string Modelo { get; set; }
    public int CapacidadPasajeros { get; set; }
    public int VelocidadMaxima { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Capacidad de pasajeros: " + CapacidadPasajeros);
        Console.WriteLine("Velocidad máxima: " + VelocidadMaxima + " km/h");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de registro de aviones");

        int cantidadAviones;

        Console.Write("Ingrese la cantidad de aviones: ");
        cantidadAviones = Convert.ToInt32(Console.ReadLine());

        Avion[] aviones = new Avion[cantidadAviones];

        for (int i = 0; i < cantidadAviones; i++)
        {
            Console.WriteLine("Ingrese la información del avión " + (i + 1));

            aviones[i] = new Avion();

            Console.Write("Modelo: ");
            aviones[i].Modelo = Console.ReadLine();

            Console.Write("Capacidad de pasajeros: ");
            aviones[i].CapacidadPasajeros = Convert.ToInt32(Console.ReadLine());

            Console.Write("Velocidad máxima: ");
            aviones[i].VelocidadMaxima = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();

        // Mostrar la información de los aviones
        Console.WriteLine("Esta es la información de los aviones que ingresaste");
        foreach (var avion in aviones)
        {
            avion.MostrarInformacion();
            Console.WriteLine();
        }

        Console.ReadLine();

        Console.ReadKey();
    }
}