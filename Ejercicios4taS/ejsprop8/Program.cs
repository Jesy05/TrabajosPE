using System;

class Program
{
    // Variable global para controlar si la sesión está iniciada
    static bool sesionIniciada = false;

    static void Main()
    {
        IniciarSesion();
    }

    static void IniciarSesion()
    {
        Console.Write("Ingresa la contraseña: ");
        string pass = Console.ReadLine();

        if (pass == "1234")
        {
            sesionIniciada = true; // Cambio el valor de la variable global
            Console.WriteLine("Sesión iniciada correctamente.");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta.");
        }
    }
}

