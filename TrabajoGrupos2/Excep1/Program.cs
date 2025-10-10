// Primer ejemplo de manejo de excepciones en C#

using System;        // Espacio de nombres básico de C#
using System.IO;     // Necesario para usar la clase File y las excepciones de archivos

class Program
{
    static void Main()
    {
        try // Bloque try para código que puede generar excepciones
        {
            // Código que puede generar un error
            string contenido = File.ReadAllText("datos.txt");
            Console.WriteLine(contenido);
        }
        catch (FileNotFoundException ex) // Catch lo que hace es básicamente capturar la excepción
        { 
            // Filenotfoundexception, por ejemplo, es uno de esos tipos de excepciones que vienen de
            // System.Exception, y se usa para manejar cuando no encuentra un archivo
            Console.WriteLine("Error: " + ex.Message); // si el problema coincide con
            // el tipo de excepción, se ejecuta este bloque
        }
        catch (UnauthorizedAccessException ex) // esta excepción es para cuando el archivo está 
        // protegido o la carpeta requiere permisos de administrador.
        {
            Console.WriteLine("Error: No tienes permiso para acceder al archivo.");
        }
        catch (Exception ex) // este ya es un catch genérico, que captura cualquier otra excepción que 
        // se haya escapado de los anteriores
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
        finally // finally lo podemos comparar con un return porque es lo que nos devuelve el resultado final   
        {
            Console.WriteLine("Proceso finalizado, se liberaron los recursos.");
        }
    }
}
