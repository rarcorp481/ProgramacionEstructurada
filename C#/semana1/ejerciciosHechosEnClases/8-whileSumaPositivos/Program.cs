using System;

class Program
{
       static void Main()
    {
        Console.WriteLine("Programa para aprender a utilizar la estructura while");
        int num, suma = 0; 
        Console. Write("Ingrese un número positivo (o un número negativo para terminar el bucle While): ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num > 0)
        {
            suma += num;
            Console.Write("Ingrese un número positivo (o un número negativo para terminar el bucle While): ");
            num = Convert.ToInt32(Console.ReadLine());
            
        }
        Console.WriteLine("La suma de los números positivos es: " + suma);
        Console.WriteLine("\nPresione Enter para salir...");
        Console.ReadLine();
    }
}