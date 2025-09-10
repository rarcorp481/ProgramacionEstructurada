using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace mayorEntreTres
{
    internal class Program
    {
        static void MayorEntreTres()
        {
            Console.WriteLine("Caclcular el número mayor de 3 números.");

            int[] numeros = new int[3];
            int i = 0;
            int num;

            // Solicitar los 3 números
            while (i < 3)
            {
                Console.Write($"\nIngrese el número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    numeros[i] = num;
                    i++;
                }
                else Console.WriteLine("\nEscribe un número válido.");
            }

            int mayor = numeros[0];

            // Buscar el mayor entre los tres
            for (int ii = 1; ii < numeros.Length; ii++)
            {
                if (numeros[ii] > mayor)
                {
                    mayor = numeros[ii];
                }
            }

            Console.WriteLine($"El mayor es: {mayor}");
        }
        static void Main(string[] args)
        {
            MayorEntreTres();
        }
    }
}
