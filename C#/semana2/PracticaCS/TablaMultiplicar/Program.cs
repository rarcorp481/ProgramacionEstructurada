namespace TablaMultiplicar
{
    internal class Program
    {
        static void TablaMultiplicar()
        {
            int num;
            int contador = 1;
            int op;

            Console.WriteLine("Tabla de multiplicar con do-while.");

            while (true) 
            {
                Console.Write("\nIngrese un número: ");
                if (int.TryParse(Console.ReadLine(), out num)) break; //acepta tanto positivos como negativos
                else Console.WriteLine("Escribe un número válido."); ;
            }
            Console.WriteLine("\n----------------");

            do
            {
                op = num * contador;
                Console.WriteLine($" {num} x {contador} = {op}");
                Console.WriteLine("----------------");
                contador++;
            }
            while (contador <=10);
        }
        static void Main(string[] args)
        {
            TablaMultiplicar();
        }
    }
}
