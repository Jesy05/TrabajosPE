using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Llamo al método que calcula el perímetro con variables locales
        double perimetro = CalcularPerimetro(radio);

        Console.WriteLine("El perímetro del círculo es: " + perimetro);
    }

    static double CalcularPerimetro(double r)
    {
        // Aquí uso solo variables locales
        double perimetro = 2 * Math.PI * r;
        return perimetro;
    }
}
