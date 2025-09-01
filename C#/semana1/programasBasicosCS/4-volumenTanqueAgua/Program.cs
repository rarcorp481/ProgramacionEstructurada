//Desarrolle un programa que calcule el volumen total en metros cúbicos de agua recolectada en un tanque en una finca de Masaya.
// Utiliza como entradas la longitud, el ancho y la altura del tanque. Todos proporcionados por el usuario.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n== CÁLCULO DEL VOLUMEN DE AGUA RESPECTO A LAS DIMENSIONES DE UN TANQUE ===");
        Console.Write("\nIngresa la longitud del tanque en metros: "); // longitud
        if (!double.TryParse(Console.ReadLine(), out double Longitud) || Longitud <= 0)
        {
            Console.WriteLine("\nIngresa un número válido para la longitud. Intenta de nuevo.");
            return;
        }

        Console.Write("\nIngresa el ancho del tanque en metros: "); // ancho
        if (!double.TryParse(Console.ReadLine(), out double Ancho) || Ancho <= 0)
        {
            Console.WriteLine("\nIngresa un número válido para el ancho. Intenta de nuevo.");
            return;
        }

        Console.Write("\nIngresa la altura del tanque en metros: "); // altura
        if (!double.TryParse(Console.ReadLine(), out double Altura) || Altura <= 0)
        {
            Console.WriteLine("\nIngresa un número válido para la altura. Intenta de nuevo.");
            return;
        }

        double VolumenParalelepipedo = Longitud * Ancho * Altura;
        Console.WriteLine($"\nEl  volumen total de un tanque de {Longitud}m de longitud, {Ancho}m de ancho y {Altura}m de altura con agua recolectada es de {VolumenParalelepipedo:F3}m^3.\n");

    }
}
