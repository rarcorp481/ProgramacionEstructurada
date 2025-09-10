//convertidor de días en semanas y días restantes

using System.Numerics;
using System.Transactions;

namespace ConvertSemana
{
    internal class Program
    {
        static void ConvertidorSemanas()
        {
            int days, days2;
            double week;
            

            Console.WriteLine("Convertidor de días en semanas y días restantes.");
            while (true)
            {
                Console.Write("\nEscribe la cantidad de días que deseas convertir: ");
                if (int.TryParse(Console.ReadLine(), out days) && days > 0 )
                {
                    week = days / 7;
                    days2 = days % 7;
                    break;
                }
                else Console.WriteLine("Ingresa una cantidad de días válida");
                
            }
            if (days2 == 0) Console.WriteLine($"\n{days} días equivalen a {week:F0} semanas.");
            else Console.WriteLine($"\n{days} días equivalen a {week:F0} semanas y {days2} días.");

        }
        static void Main(string[] args)
        {
            ConvertidorSemanas();
        }
    }
}
