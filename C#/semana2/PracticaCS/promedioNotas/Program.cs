using System;

namespace promedioNotas
{
    internal class Program
    {
        static void PromedioNotas()
        {
            Console.WriteLine("Calcular el promedio de N calificaciones.");


            int i = 1;
            int num;
            int notas;
            int suma = 0;

            while (true)
            {
                Console.Write("\nIngrese la cantidad de calificaciones que desea ingresar (entero positivo !1): ");
                if (int.TryParse(Console.ReadLine(), out num) && num >= 2) break;
                else Console.WriteLine("Escribe un número válido.");

            }
            while (i <= num)
            {
                while (true)
                {
                    Console.Write($"\nIngrese la nota {i}: ");
                    if (int.TryParse(Console.ReadLine(), out notas) && notas >= 0 && notas <=100) break;
                    else Console.WriteLine("Escribe una nota válida (mayor o igual a cero 0 y menor o igual a 100)."); ;
                }
                suma += notas;
                i++;
            }
            double promedio = suma / num;
            Console.WriteLine($"\nEl promedio de las {num} notas es: {promedio}");
        }
        static void Main(string[] args)
        {
            PromedioNotas();
        }
    }
}
