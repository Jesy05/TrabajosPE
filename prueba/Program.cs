// Descripción: Este programa para determinar si un número ingresado es positivo, negativo o cero usando if.
class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = Convert.ToInt32(Console.ReadLine()); //El ToInt32 convierte la entrada de texto en un número entero, para manejar errores de entrada

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es cero."); 
        }
        Console.ReadKey(); //Mantiene la consola abierta hasta que se presione una tecla
    }
}

