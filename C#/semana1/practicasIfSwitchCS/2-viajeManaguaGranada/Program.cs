// Desarrolle un programa que calcule el tiempo total en horas de un viaje desde Managua a Granada.
// Donde el usuario ingresa la velocidad en kilómetrod por hora como entrada asumiendo una distancia fija de 40 km.

using System;

class Program
{
    static void Main()
    {
        const int Distancia = 40;

        Console.WriteLine("\n=== HORAS DE VIAJE DESDE MANAGUA A GRANADA (40km) ===");
        Console.Write("Ingresa la velocidad promedio en km/h (Ingresa solo en número): ");
        if (!double.TryParse(Console.ReadLine(), out double VelocidadPromedio) || VelocidadPromedio <= 0) // Devuelve True si el valor ingresado no es un double (Se invierte el bool para que siga el if, por ello el !). Devuelve el código al main.
        {                                                                                                 // el bloque "|| VelocidadPromedio <= 0" valida que la velocidad no sea cero. Por lo que en el caso de que ninguna  condición  sea correcta tira false
                                                                                                          // Si tira false es porque el dato está correcto.
            Console.WriteLine("\nEntrada de velocidad inválida. Por favor ingresa un número válido.");
            return;
        }

        double Horas = Distancia / VelocidadPromedio;

        Console.WriteLine($"El total de horas en llegar de Managua a Granada ({Distancia}km) a una velocidad de {VelocidadPromedio}km/h es de {Horas:F2}h\n");
    }
}

