using System.ComponentModel;
using System.Data;

namespace Funcion1;

class Program
{
    // Pedir el nombre de una persona y saludarlo
    static String Saludar(String? nombre)
    {
        return $"Hola {nombre} mucho gusto.";
    }

    //Función para determinar la edad del usuario 
    static String ClasificarEdad(int edad)
    {
        // niños = 13, adolescentes = 14, adultos = 18

        if (edad <= 0 || edad > 120) return "Escribe una edad válida.";
        if (edad <= 13) return "Eres un niño.";
        if (edad < 18 && edad > 13) return "Eres un adolescente.";
        if (edad >= 18) return "Eres un adulto.";
        return "Eror inesperado.";
    }

    static void Menu()
    {
        int edad;
        string? nombre;
        string? respuesta;

        Console.Write("\nEscribe un nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine(Saludar(nombre));

        Console.Write("\nEscribe tu edad: ");
        if (!int.TryParse(Console.ReadLine(), out edad)) Console.WriteLine("\nIngresa un número válido.");
        Console.WriteLine(ClasificarEdad(edad));

        Console.Write("\nDesea continuar? (si/no): ");
        respuesta = Console.ReadLine();

        if (respuesta == "si") Menu();
        else if (respuesta == "no") Console.WriteLine("\nSaliendo del programa...");
        else
        {
            Console.WriteLine("Escribe una respuesta válida.");
            Menu();
        }


    }
    static void Main(string[] args)
    {
        
        Menu();
    }
}

