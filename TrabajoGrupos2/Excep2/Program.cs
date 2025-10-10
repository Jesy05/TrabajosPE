// Segundo ejemplo: manejo de excepciones al escribir archivos en C#

using System;
using System.IO;

class EjemploEscritura
{
    static void Main()
    {
        string ruta = "registro.txt"; // Nombre del archivo donde se guardarán los datos

        try
        {
            // Validar si el archivo ya existe
            if (File.Exists(ruta)) // este es un ejemplo más básico de manejo de excepciones
             // con condicionales antes de intentar escribir en un archivo y también usanmos algunas de 
             // las excepciones que mencionamos antes
            {
                Console.WriteLine("El archivo ya existe. Se agregarán nuevos datos...");
            }
            else
            {
                Console.WriteLine("Creando nuevo archivo...");
            }

            // using garantiza que el archivo se cierre automáticamente
            using (StreamWriter escritor = new StreamWriter(ruta, true)) // true → agrega texto sin borrar lo anterior
            {
                escritor.WriteLine("Registro creado en: " + DateTime.Now);
                escritor.WriteLine("Usuario: Jesy");
                escritor.WriteLine("----------------------");
            }

            Console.WriteLine("Los datos fueron escritos correctamente.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: No tienes permiso para escribir en esta ubicación.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Error: La carpeta especificada no existe.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error de entrada/salida: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finalizó la operación de escritura.");
        }
    }
}
