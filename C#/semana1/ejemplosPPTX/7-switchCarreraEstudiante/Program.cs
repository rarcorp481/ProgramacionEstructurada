using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa para aprender a utilizar la estructura switch");
        Console.Write("Ingrese un número del 1 al 3 para ver en qué carrera puede estudiar: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Tu carrera es: Medicina.");
                break;
            case 2:
                Console.WriteLine("Tu carrera es: Ingeniería en Sistemas.");
                break;
            case 3:
                Console.WriteLine("Has decidido ser emprendedor.");
                break;
            default:
                Console.WriteLine("Número inválido. Por favor, ingrese un número del 1 al 3.");
                break;
        }
        Console.WriteLine("Presione Enter para salir...");
        Console.ReadLine();
    }
}

