// Programa para calcular el área total en manzanas de un terreno en una finca nicaragüense, donde el usuario ingresa 
// la longitud y el ancho en varas (1 manzana = 1,428.8 varas²) utilizando  una cantidad fija de 5 varas de ancho 
// y la longitud como entrada.
using System;

class Program
{
    static void Main()
    {
        const double VarasCuadradasPorManzana = 1428.8;
        const double AnchoTerreno = 5.0; // Le puse const para definir que son constantes en el programa aunque realmente no sea necesario en este caso por lo corto qeu es el ejecicio

        Console.WriteLine("\n=== CÁLCULO DEL ÁREA TOTAL DE UN TERRENO RECTANGULAR ===");
        Console.Write("Ingrese la longitud del terreno en Varas: ");
        if (!double.TryParse(Console.ReadLine(), out double LargoTerreno) || LargoTerreno <= 0)
        {
            Console.WriteLine("Ingrese una longitud válida. Intente de nuevo por favor.");
            return;
        }

        Console.WriteLine("\nCalculando...");
         double TotalManzanas = AnchoTerreno * LargoTerreno / VarasCuadradasPorManzana;
        Console.WriteLine($"El área total del terreno de {AnchoTerreno} vars de ancho y {LargoTerreno} vars de largo es de {TotalManzanas:F4} manzanas.\n"); 
    }
}
