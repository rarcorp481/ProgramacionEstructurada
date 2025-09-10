using System;

namespace negativoPositivo
{
    internal class Program
    {
        static void NegativoPositivo()
        {
            Console.WriteLine("Número positivo o negativo.");

            int num;

            while (true)
            {
                Console.Write("\nIngrese un número: ");
                if (int.TryParse(Console.ReadLine(), out num)) break;
                else Console.WriteLine("Escribe un número válido."); ;
            }
            if (num > 0) Console.WriteLine("\nEl número es positivo.");
            else if (num < 0) Console.WriteLine("\nEl número es negativo.");
            else Console.WriteLine("\nEl número es 0.");
        }
        static void Main(string[] args)
        {
           NegativoPositivo();
        }
    }
}
