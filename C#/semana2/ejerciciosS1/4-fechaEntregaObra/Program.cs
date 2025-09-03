using System;
using System.Globalization;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        var cultura = CultureInfo.GetCultureInfo("es-NI");
        const string formato = "dd/MM/yyyy"; ;
        int countError = 0;

        Console.WriteLine("=== PROGRAMA DE VERIFICACIÓN DE FECHA ===");

        while (true) 
        {
            
            Console.Write("Fecha de entrega: ");
            string? texto = Console.ReadLine();
            if (DateTime.TryParseExact(texto, formato, cultura, DateTimeStyles.None, out var fecha))
            {
                Console.WriteLine($"La fecha ingresada fue ingresada correctamente: {fecha:dd/MM/yyyy}");
                break;
            }
            else
            {
                Console.WriteLine("Error: Ingrese una fecha con el formato dd/MM/yyyy (ej. 21/03/2000)\n");
                countError++;
                continue;
            }
        }
        Console.WriteLine($"\nCantidad de intentos fallidos: {countError}");

    }   
}
