using System;

class Program
{
    static double CalcularAreaTriangulo(double baseT, double altura)
    {
        return (baseT * altura) / 2;
    }

    static void Main()
    {
        double area = CalcularAreaTriangulo(10, 5);
        Console.WriteLine("Área del triángulo: " + area);
    }
}
