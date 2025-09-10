using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===SISTEMA DE REGISTRO DE CLIENTES===");
        Console.WriteLine("\nDATOS CLIENTE:");

        int contadorErrores = 0, caracteresNombre;
        string nombreCliente;

        while (true)
        {
            try
            {
                Console.Write("Nombre: ");
                string? entrada = Console.ReadLine(); 
                if (string.IsNullOrWhiteSpace(entrada)) entrada = null; // Verifica si entrada aplica para null
                nombreCliente = Regex.Replace(entrada!, "[^A-Za-z ]", "").ToUpper(); //Reemplaza chr que no sean alfabéticos por "" y capitaliza
                caracteresNombre = nombreCliente!.Length; // Cuenta la cantidad de caracteres
                break;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("\nIngrese un nombre válido.");
                contadorErrores++;
                continue;
            }
        }

        int phoneNumber;

        while (true)
        {
            try
            {
                Console.Write("Ingrese su número de teléfono: ");
                string? entrada2 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada2)) entrada2 = null; // Verifica si entrada2 aplica para null 
                entrada2 = entrada2!.Trim('-', ' '); //Elimina guiones o espacios en blanco
                phoneNumber = int.Parse(entrada2);
                break;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("\nIngrese un número válido.");
                contadorErrores++;
                continue;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nIngrea un número válido.");
                contadorErrores++;
                continue;
            }
        }

        Console.WriteLine("\n=== DATOS DEL CLIENTE ===");
        Console.WriteLine($"Nombre: {nombreCliente}");
        Console.WriteLine($"Número telefónico: {phoneNumber}");
        Console.WriteLine($"\nERRORES DURANTE EL PROCESO DE REGISTRO: {contadorErrores}");
        Console.WriteLine($"\n# DE CARACTERES EN EL NOMBRE: {caracteresNombre}"); 
    }
}

