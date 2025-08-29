using System;

class Program
{
    static void Main()
    {
        Console.Write("\nEscriba la clasificación de la clase de matemáticas (0-100): ");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        if (calificacion >= 90)
        {
            Console.WriteLine("Calificación excelente.\n");
        }
        else if (calificacion >= 80 && calificacion < 90)
        {
            Console.WriteLine("Calificación muy buena.\n");
        }
        else if (calificacion >= 70 && calificacion < 80)
        {
            Console.WriteLine("Calificación regular.\n");
        }
        else
        {
            Console.WriteLine("Has reprobado la clase, necesitas mejorar.\n");
        }
    }
}