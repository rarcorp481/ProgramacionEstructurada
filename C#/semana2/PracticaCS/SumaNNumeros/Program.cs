using System.Runtime.InteropServices;

namespace SumaNNumeros
{
    internal class Program
    {
        static void SumaNaturales()
        {
            int num;

            Console.WriteLine("Suma de los primeros N números naturales.");
            while (true)
            {
                Console.Write("\nIngresa un número entero positivo: ");
                if (int.TryParse(Console.ReadLine(), out num) && num > 0) break;
                else Console.WriteLine("Escribe un número válido (n > 0)."); ;
            }

            int suma = 0;
            int iterable = 0;

            while (iterable < num)
            {
                iterable++;
                suma = suma + iterable;
            }

            Console.WriteLine($"La suma de todos los números desde 1 hasta {num} es de: {suma}");
        }
        static void Main(string[] args)
        {
            SumaNaturales();
        }
    }
}
