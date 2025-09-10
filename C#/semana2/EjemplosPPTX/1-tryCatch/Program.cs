using System;


namespace Exception1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Escribe un número: ");
                int a = Convert.ToInt32(Console.ReadLine()); 
                Console.Write("Escribe otro número: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int resultado = a / b; // Aquí ocurre una excepción: DivideByZeroException si se escribe 0 como valor de b
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            finally
            {
                Console.WriteLine("Este bloque siempre se ejecuta (aunque se divida por cero).");
            }

        }
    }
}

    