using System;

class Program
{
    static void Main()
    {
        CalcularEdad();
    }

    static void CalcularEdad()
    {
        // Variables locales para año de nacimiento y edad
        Console.Write("Ingresa tu año de nacimiento: ");
        int nacimiento = Convert.ToInt32(Console.ReadLine());

        int anioActual = DateTime.Now.Year;
        int edad = anioActual - nacimiento;

        // No guardo la edad globalmente, solo la calculo aquí
        Console.WriteLine("Tu edad es: " + edad);
    }
}
