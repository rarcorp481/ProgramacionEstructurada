// Desarroller un programa que calcule el monto total a pagar por al compra 
// de una cantidad especídica de un producto, donde el precio por unidad se proporciona
// como una variable de entrada desconocida ingresada por el usuario

using System;

class Program
{
    static void Main()
    {
        int cantidad;
        decimal PrecioUnitario, MontoTotal;
        Console.WriteLine("Ingrese el precio por unidad del producto:");
        PrecioUnitario = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de productos a  comprar:");
        cantidad = Convert.ToInt32(Console.ReadLine());
        MontoTotal = cantidad * PrecioUnitario;
        Console.WriteLine($"El monto total a pagar por {cantidad} productos es: {MontoTotal:C}");
        Console.ReadLine();
    }
}