using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe tu edad actual: ");
        int edad = int.Parse(Console.ReadLine());
        
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
    }
}

