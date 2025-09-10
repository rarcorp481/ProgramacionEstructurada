using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe la temperatura ambiente de la habitación: ");
        int temperatura = Convert.ToInt32(Console.ReadLine());

        if (temperatura > 25)
        {
            Console.WriteLine("Hace calor.");
        }
        else
        {
            Console.WriteLine("No hace calor.");
        }
    }
}
