// Crea un programa que calcule si un año es año biciesto o no. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===¿ES UN AÑO BICIESTO?===\n");
        Console.Write("Ingresa un año válido (Como 2000, 1998, etc..): ");
        string? entrada = Console.ReadLine();
        int año;

        while (!int.TryParse(entrada, out año) || año <= 0) // Validación de entrada para asegurarse de que es un número entero positivo.
        {
            Console.WriteLine("El valor ingresado no es un año válido.");
            Console.Write("\nPor favor, ingresa un año válido (Como 2000, 1998, etc..): ");
            entrada = Console.ReadLine();
        }
        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0)) // Regla para determinar si un año es biciesto mediante restos de divisiones.
        {
            Console.WriteLine($"\nEl año {año} es un año biciesto.");
        }
        else
        {
            Console.WriteLine($"\nEl año {año} no es un año biciesto.");
        }
        Console.Write("Presione enter para salir: ");
        Console.ReadLine();
    }
}