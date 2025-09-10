using System;

namespace ParesImpares
{
    internal class Program
    {
        static void ParesImpares()
        {
            Console.WriteLine("Contar números Pares e Impares");

            int num;
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    Console.Write("\nIngrese un número: ");
                    if (int.TryParse(Console.ReadLine(), out num)) break;
                    else Console.WriteLine("Escribe un número válido."); ;
                }
                if (num % 2 == 0) pares++;
                else impares++;
            }
            Console.WriteLine($"\nPares escritos: {pares}");
            Console.WriteLine($"Impares escritos: {impares}");
        }
        static void Main(string[] args)
        {
            ParesImpares();
        }
    }
}
