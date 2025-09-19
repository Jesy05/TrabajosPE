//Descripcion del porgrama: Desarrolla una función en C# que reciba como parámetro una cadena de
//texto ingresada por el usuario y devuelva la cantidad de vocales que
//contiene.

using System;

class Program
{
    // Función que cuenta las vocales en una cadena de texto
    static int ContarVocales(string texto) // recibe un parámetro de tipo string y devuelve un entero
                                           // Ese seria un parametro por valor, ya que se pasa una copia del valor original a la función.
                                           // el valor original siendo la cadena ingresada por el usuario.
    {
        int contador = 0; // inicializa el contador de vocales
        string vocales = "aeiouAEIOU"; // define las vocales a buscar
        foreach (char c in texto) // foreach para recorrer cada caracter en la cadena que puso el usuario
        {       // c es el caracter actual en la iteración para comparar
            if (vocales.Contains(c)) // si encontramos vocales contenidas en donde va iterando c 
            {                        // las va a sumar al contador
                contador++;
            }
        }
        return contador;            // devuelve el total de vocales encontradas
    } 

    static void Main() 
    {
        Console.Write("Ingrese una cadena de texto: ");
        string entrada = Console.ReadLine();
        int cantidadVocales = ContarVocales(entrada);
        Console.WriteLine($"La cantidad de vocales es: {cantidadVocales}");
    }
}