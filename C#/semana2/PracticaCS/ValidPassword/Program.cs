namespace ValidPassword
{

    internal class Program
    {
        static void ValidPassword()
        {
            Console.WriteLine("Validación de contraseña. ");
            Console.Write("\nIngresa una contraseña: ");
            string? password = Console.ReadLine();

            string? attemp;
            int fail = 0;

            do
            {
                Console.Write("\nReingresa tu contraseña: "); attemp = Console.ReadLine();
                if (attemp != password)
                {
                    Console.WriteLine("Contraseña incorrecta, intenta de nuevo.");
                    fail++;
                }
                else 
                {
                    Console.WriteLine("\nIniciando Sesión...");
                    break;
                }
            }
            while (true);

            Console.WriteLine($"\nIntentos fallidos: {fail}");

        }
        static void Main(string[] args)
        {
            ValidPassword();
        }
    }
}
