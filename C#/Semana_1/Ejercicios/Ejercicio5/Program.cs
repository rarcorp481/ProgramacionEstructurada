//Desarrolle un programa que calcule la cantidad total de balde de leche producida en un día en una lechería de Estelí.
// Utiliza como entradas el volumen promedio por vaca en litros y el número total de vacas ordeñadas. 
// Todos los datos son proporcionados por el usuario (1 balde = 20 litros)

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nPrograma para calcular la cantidad total de baldes de leche producidos por una lechería en Estelí.");
        Console.Write("\nIngresa el volumen promedio por vaca en litros: ");
        if (!double.TryParse(Console.ReadLine(), out double VolumenPromedio) || VolumenPromedio <= 0)
        {
            Console.WriteLine("\nIngresa un número de volumen válido. Intenta de nuevo.");
            return;
        }

        Console.Write("\nIngresa la cantidad de vacas ordeñadas: ");
        if (!double.TryParse(Console.ReadLine(), out double VacasOrdeñadas) || VacasOrdeñadas <= 0)
        {
            Console.WriteLine("\nIngresa un número de vacas ordeñadas válido. Intenta de nuevo.");
            return;
        }

        double Baldes = VolumenPromedio * VacasOrdeñadas / 20;
        Console.WriteLine($"\nLa lechería en Estelí produce al día unos {Baldes} baldes de leche si el volúmen promedio de vaca es de {VolumenPromedio} y la cantidad de vacas ordeñadas es de {VacasOrdeñadas}.\n");
    }
}