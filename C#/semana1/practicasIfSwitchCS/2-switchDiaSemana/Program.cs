using System;

class Program
{
    static void Main()
    {

        string NombreDia;
        Console.WriteLine("=== DÍAs DE LA SEMANA ===");
        Console.Write("\nIngrese un número del 1 al 7: ");

        if (!int.TryParse(Console.ReadLine(), out int DiaSemana) || DiaSemana < 1 || DiaSemana > 7) // int.TryParse() devuelve true o false si fue capaz de convertir el str a int
        {
            Console.Write("\nEntrada Inválida.\nPor favor ingresa un número entero válido.");
        }

        switch (DiaSemana)
        {
            case 1:
                NombreDia = "\nEl 1 le corresponde al día Lunes\n";
                break;
            case 2:
                NombreDia = "\nEl 2 le corresponde al día Martes\n";
                break;
            case 3:
                NombreDia = "\nEl 3 le corresponde al día Miércoles\n";
                break;
            case 4:
                NombreDia = "\nEl 4 le corresponde al día Jueves\n";
                break;
            case 5:
                NombreDia = "\nEl 5 le corresponde al día Viernes\n";
                break;
            case 6:
                NombreDia = "\nEl 6 le corresponde al día Sábado\n";
                break;
            case 7:
                NombreDia = "\nEl 7 le corresponde al día Domingo\n";
                break;
            default: // Bloque para definir una acción si el str está vacío
                Console.WriteLine(" El número tiene que estar entre 1 y 7.\n");
                return;
        }

        Console.WriteLine(NombreDia); // Imprime la opción que haya sido seleccionada
        Console.Write("\nPresione enter para salir: ");
        Console.ReadLine(); 
    }
}