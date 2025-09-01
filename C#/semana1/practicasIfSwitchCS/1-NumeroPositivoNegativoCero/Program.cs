// Determinar si un número ingresado es posiitivo, negativo o cero.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ¿ES POSITIVO, NEGATIVO O CERO? ===");
        Console.Write("Ingrese un número: ");
        string? entrada = Console.ReadLine();

        if (!double.TryParse(entrada, out double numero))
        {
            Console.WriteLine("\nEntrada inválida. Por favor, ingrese un número válido.");
        }
        else if (Convert.ToDouble(entrada) > 0)
        {
            Console.WriteLine("\nEl número es positivo.");
        }
        else if (Convert.ToDouble(entrada) < 0)
        {
            Console.WriteLine("\nEl número es negativo.");
        }
        else
        {
            Console.WriteLine("\nEl número es cero.");
        }

        Console.Write("\nPresiona enter para salir: ");
        Console.ReadLine();
    }
}
