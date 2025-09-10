using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===CATEGORIZACION DE NOTAS===");
        Console.Write("Ingrese la nota de su clase (0-100): ");
        string? entrada = Console.ReadLine();
        int nota;

        while (!int.TryParse(entrada, out nota) || nota > 100 || nota < 0)
        {
            Console.WriteLine("\nIngresa una nota válida, vuelve a intentarlo:");
            Console.Write("Ingrese la nota de su clase (0-100): ");
            entrada = Console.ReadLine();
        }
        switch (nota)
        {
            case >= 90 and <= 100:
                Console.WriteLine("\nCalificación excelente. Has aprobado.\n");
                break;
            case >= 80 and < 90:
                Console.WriteLine("\nCalificación buena. Has aprobado.\n");
                break;
            case >= 70 and < 80:
                Console.WriteLine("\nCalificación regular. Has aprobado.\n");
                break;
            case >= 50 and < 70:
                Console.WriteLine("\nTienes que ir a recuperación.\n");
                break;
            default:
                Console.WriteLine("\nHas reprobado la clase, necesitas mejorar.\n");
                break;
        }
        Console.Write("Presione enter para salir: ");
        Console.ReadLine();
    }
}