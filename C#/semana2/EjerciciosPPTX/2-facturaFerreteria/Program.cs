// Programa para  pedir la cantidad (int) y un precio unitario (decimal) para calcular el iva (0.15 * subtotal) y el total (subtotal + iva).
//Capture el  formato inválido y desbordes con mensajes útiles.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PROGRAMA DE FACTURAS PARA UNA FERRETERÍA ===");

        // bucle encargado de validar la entrada de cantidadArticulos
        int cantidadArticulos;

        while (true)
        {
            try
            {
                Console.Write("\nCantidad de artículos: ");
                cantidadArticulos = int.Parse(Console.ReadLine());


                if (cantidadArticulos <= 0)
                {
   
                    Console.WriteLine("Entrada de cantidad inválida. Ingresa un número positivo != 0: ");
                    continue;
                }
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: La entrada no tiene el formato necesario. Usa solo números.");
                continue;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"OverflowException: La entrada sobrepasa el rango máximo, ingrese un número por debajo de {int.MaxValue}.");
                continue;
            }

        }
        // bucle encargado de validar la entrada de precioUnidad
        decimal precioUnidad;

        while (true)
        {
            try
            {
                Console.Write("\nPrecio unitario (C$): ");
                precioUnidad = decimal.Parse(Console.ReadLine());


                if (precioUnidad <= 0)
                {
                    Console.WriteLine("Entrada del precio unitario inválida. Ingresa un número positivo != 0: ");
                    continue;
                }
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: La entrada no tiene el formato necesario. Usa solo números.");
                continue;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"OverflowException: La entrada sobrepasa el rango máximo, ingrese un número por debajo de {int.MaxValue}.");
                continue;
            }

        }
        // bloque de cálculos aritméticos
        decimal subtotal = precioUnidad * cantidadArticulos;
        decimal iva = subtotal * 0.15m;
        decimal total = subtotal + iva;

        // formato factura
        Console.WriteLine($"\nSUBTOTAL: {subtotal:F2}C$\nIVA: {iva:F2}C$\nTOTAL: {total:F2}C$");
        
    }
}

    


