using System;

namespace MenuDeOpciones
{
    internal class Program
    {
        static void Menu()
        {
            string? dato;
            DateTime ahora = DateTime.Now;

            Console.WriteLine("Menú de opciones usando Switch.");
            Console.WriteLine("\nIngrese uno de las opciones de este menú:\n1. Saludar\n2.Mostrar fecha actual\n3. Salir");

            
            while (true)
            {
                Console.Write("\n==> ");
                dato = Console.ReadLine();
                if (dato == "1" || dato == "2" || dato == "3") break;
                else Console.WriteLine("\nEscribe una opción válida (1, 2 o 3)."); ;
            }

            switch (dato)
            {
                case "1":
                    Console.WriteLine("\nHola, cómo estás?");
                    break;
                case "2":
                    Console.WriteLine($"\n{ahora.ToString("d")}");
                    break;
                case "3":
                        Console.WriteLine("\nSaliendo del programa...");
                    break;
            }
        }   
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
