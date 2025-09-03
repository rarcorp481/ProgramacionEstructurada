double num1, num2;
double division;

Console.WriteLine("===PROGRAMA PARA DIVIDIR DOS NÚMEROS===");
Console.Write("Digite un número: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite otro número: ");
num2 = Convert.ToDouble(Console.ReadLine());

if (num2 == 0)
{
    Console.WriteLine("No se puede dividir entre cero amorcito.");
}
else
{
    division = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {division}");
}
