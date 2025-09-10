using System;
using System.Text;

class  Program 
{
    static void Main(string[] args) 
    {
        decimal gastoTotal;
        int numeroParticipantes;

        Console.WriteLine("=== PROGRAMA PARA CALCULAR REPARTO DE GASTOS EN UNA GIRA ===");
        Console.Write("\nIngrese el gasto total de la gira en $: ");
        string? entrada = Console.ReadLine();

        // bucle para validar la entrada del gasto total de la gira
        while (!decimal.TryParse(entrada, out gastoTotal) || gastoTotal < 0) 
        {
            Console.Write("Entrada inválida. Por favor, ingrese un número válido para el gasto total: ");
            entrada = Console.ReadLine();
        }
        Console.Write("\nIngrese el número de participantes en la gira: ");
        entrada = Console.ReadLine();

        // bucle para validar la entrada del número de participantes
        while (!int.TryParse(entrada, out numeroParticipantes) || numeroParticipantes < 0) // se pudo haber puesto <= 0 pero se maneja la excepción de división por cero en el bloque try-catch como se pide en el enunciado

        {
            Console.Write("Entrada inválida. Por favor, ingrese un número válido para el número de participantes: ");
            entrada = Console.ReadLine();
        }

        //bucle para manejar la excepción de división por cero
        while (true)
        {
            try
            {
                Console.WriteLine($"\nTotal: {gastoTotal}$\nParticipantes: {numeroParticipantes}\nCada participante debe pagar: {gastoTotal / numeroParticipantes:F2}$");
                break;
            }
            catch (DivideByZeroException)
            {
                Console.Write("\nError: El número de participantes no puede ser cero. Reintenta para ingresar un número válido: ");
                string? entrada2 = Console.ReadLine();

                if (!int.TryParse(entrada2, out numeroParticipantes) || numeroParticipantes <= 0)  // Forzar al usuario a ingresar un número válido repitiendo el ciclo hasta que lo haga
                {
                    continue; // sigue con el ciclo hasta que entrada2 sea mayor que 0
                }
                else
                {
                    numeroParticipantes = int.Parse(entrada2);
                }
            }
        }
            
    }

}
