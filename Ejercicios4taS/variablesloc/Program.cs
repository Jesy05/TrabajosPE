using System;
class VariablesEjemplos {
    static void Main()
    {
        int numero = 10; // Variable local
        Console.WriteLine("El número es: " + numero);
        Mostrarmensaje();
    }

    static void Mostrarmensaje()
    {
        string mensaje = "Hola desde el procedimiento!"; // Variable local
        Console.WriteLine(mensaje);
    }
}