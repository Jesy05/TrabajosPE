using System;

class Program
{
    // Variable global para contar intentos
    static int intentos = 0;
    static int numeroSecreto = 7;

    static void Main()
    {
        Jugar();
    }

    static void Jugar()
    {
        int numero;
        do
        {
            Console.Write("Adivina el número secreto: ");
            numero = Convert.ToInt32(Console.ReadLine());
            intentos++; // Cada vez que pruebo, aumento intentos
            Console.WriteLine("Intento número: " + intentos);
        } while (numero != numeroSecreto);

        Console.WriteLine("¡Adivinaste el número!");
    }
}
