using System;

class Program
{
    static void Main()
    {
        int edad = 18;
        string mensaje;

        // Operador ternario (forma corta del if-else)
        // var resultado = condición ? ValorSiVerdadero : ValorSiFalso;
        mensaje = edad >= 18 ? "Adulto" : "Menor";

        Console.WriteLine($"La persona es: {mensaje}");
    }
}
