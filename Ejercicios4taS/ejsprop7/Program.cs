using System;

class Program
{
    static void Main()
    {
        CalcularPromedio();
    }

    static void CalcularPromedio()
    {
        // Variables locales para las tres notas
        Console.Write("Ingresa la primera nota: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la segunda nota: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la tercera nota: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        double promedio = (n1 + n2 + n3) / 3;

        // Solo se usan variables locales
        Console.WriteLine("El promedio es: " + promedio);
    }
}
