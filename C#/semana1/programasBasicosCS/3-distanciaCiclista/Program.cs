// Desarrolle un programa que calcule la distancia total recorrida en kilómetos por un ciclista en el malecón de San Juan del Sur.
// Utiliza como entradas la velocidad promedio en kilómetros por hora y el tiempo recorrido. Ambos proporcionados por el  usuario. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n=== CÁLCULO DE DISTANCIA RECORRIDA CON BASE EN LA VELOCIDAD PROMEDIO Y EL TIEMPO RECORRIDO ===");

        Console.Write("Ingrese la velocidad promedio en km/h: ");
        if (!double.TryParse(Console.ReadLine(), out double VelocidadPromedio) || VelocidadPromedio <= 0)
        {
            Console.WriteLine("Ingrese un número válido para la velocidad promedio. Intente de nuevo por favor.");
            return;
        }

        Console.Write("\nIngrese el tiempo recorrido en h: ");
        if (!double.TryParse(Console.ReadLine(), out double Tiempo) || Tiempo <= 0)
        {
            Console.WriteLine("Ingrese un número válido para las horas. Intente de nuevo por favor.");
            return;
        }

        double Distancia = VelocidadPromedio * Tiempo;
        Console.WriteLine($"\nLa distancia total que se recorrió fueron de {Distancia:F2}km a una velocidad de {VelocidadPromedio}km/h en un tiempo total de {Tiempo}h.\n");
    }
}