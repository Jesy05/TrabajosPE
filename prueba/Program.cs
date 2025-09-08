// Descripción: Estos son ejemplos de como declarar distintos tipos de variable en c#
class Program
{
    static void Main()
    {
        // Declaración de variables
        int numeroEntero = 10;
        double numeroDecimal = 10.5;
        string texto = "Hola, mundo!";
        bool esVerdadero = true;


        // Uso de las variables
        Console.WriteLine("Número entero: " + numeroEntero);
        Console.WriteLine("Número decimal: " + numeroDecimal);
        Console.WriteLine("Texto: " + texto);
        Console.WriteLine("Es verdadero: " + esVerdadero);

        Console.ReadKey();
    }
}