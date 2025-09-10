using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CATEGORIZACIÓN DE NOTAS ===");
        Console.Write("\nEscriba la clasificación de la clase (0-100): ");
        string? entrada = Console.ReadLine();
        int calificacion;

        while (!int.TryParse(entrada, out calificacion) || calificacion < 0 || calificacion > 100)
        {
            Console.WriteLine("Calificación inválida: La nota debe estar entre 0 y 100.\n");
            Console.Write("Escriba la clasificación de la clase (0-100): ");
            entrada = Console.ReadLine();
        }
        if (calificacion >= 90)
        {
            Console.WriteLine("Calificación excelente. Has aprobado.\n");
        }
        else if (calificacion >= 80 && calificacion < 90)
        {
            Console.WriteLine("Calificación muy buena. Has aprobado.\n");
        }
        else if (calificacion >= 70 && calificacion < 80)
        {
            Console.WriteLine("Calificación regular. Has aprobado.\n");
        }
        else if (calificacion >= 50 && calificacion < 70)
        {
            Console.WriteLine("Tienes que ir a recuperación.\n");
        }
        else
        {
            Console.WriteLine("Has reprobado la clase, necesitas mejorar.\n");
        }
        Console.Write("Presione enter para salir: ");
        Console.ReadLine();
    }
}