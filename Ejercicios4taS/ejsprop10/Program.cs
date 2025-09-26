using System;

class Program
{
    // Variable global para la puntuación
    static int puntuacion = 0;

    static void Main()
    {
        GanarPuntos();
        GanarPuntos();
        GanarPuntos();
    }

    static void GanarPuntos()
    {
        // Cada vez que se llama al método, sumo 10 puntos
        puntuacion += 10;
        Console.WriteLine("La puntuación actual es: " + puntuacion);
    }
}
