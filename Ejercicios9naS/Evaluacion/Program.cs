using System;
using System.Collections.Generic;
using System.Linq;

// *****************************************************************************
// Descripción del Programa: Administración de Catálogo de Software Universitario
// *****************************************************************************
/// Representa un registro de software en el catálogo.
/// Es esencial definir esta estructura para que nuestra lista pueda almacenar
/// elementos con la información necesaria (Id, Nombre, Versión).

// El elemento que decidimos usar para el programa fue las listas,
// Dado que el problema de gestión de un catálogo (agregar, buscar,
// eliminar por valor) se adapta perfectamente a la naturaleza flexible
// de la Lista, opté por esa estructura como la más eficiente y directa
// para la solución

public class ProgramaSoftware
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Version { get; set; }

    // Constructor que facilita la creación de nuevos objetos
    public ProgramaSoftware(int id, string nombre, string version)
    {
        Id = id;
        Nombre = nombre;
        Version = version;
    }

    /// Sobreescribimos el método ToString() para obtener una representación
    /// legible del objeto al imprimirlo. Esto es mucho más limpio que imprimir
    /// cada propiedad por separado

    public override string ToString()
    {
        return $"[ID: {Id}] Nombre: {Nombre}, Versión: {Version}";
    }
}

// ******************************
// Clase Principal del Programa
// ******************************
public class CatalogoSoftwareApp
{
    // La lista dinámica: el corazón de nuestra aplicación.
    // Usamos List<ProgramaSoftware> porque es la estructura más adecuada para
    // las operaciones requeridas (agregar, buscar, eliminar por valor).
    private List<ProgramaSoftware> catalogo;
    private int proximoId = 1; // Contador simple para asignar IDs únicos

    // Constructor que inicializa el catálogo con algunos datos de ejemplo.
    public CatalogoSoftwareApp()
    {
        catalogo = new List<ProgramaSoftware>();
        // Datos iniciales para que el catálogo no esté vacío al empezar.
        AgregarPrograma(new ProgramaSoftware(proximoId++, "Visual Studio", "2022"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "SQL Server", "2019"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "AutoCAD", "2024"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "Microsoft Office", "365"));
        AgregarPrograma(new ProgramaSoftware(proximoId++, "Visual Studio", "2019")); // Versión obsoleta para pruebas
    }

    // ********************************
    // Métodos de Gestión del Catálogo
    // ********************************


    private void AgregarPrograma(ProgramaSoftware programa)
    {
        catalogo.Add(programa);
    }

    /// Implementa la lógica para buscar software por nombre.
    /// Usamos LINQ (Lenguaje Integrado de Consulta) con el método Where() para
    /// filtrar la lista. Es mucho más expresivo y moderno que un bucle 'foreach'
    /// manual, y es ideal para la búsqueda en colecciones.

    private List<ProgramaSoftware> BuscarSoftwarePorNombre(string nombreBusqueda)
    {
        // El ToLower() aquí es crucial para que la búsqueda sea "insensible a mayúsculas".
        // Así, 'visual studio' y 'Visual Studio' se consideran iguales.
        return catalogo
            .Where(p => p.Nombre.ToLower().Contains(nombreBusqueda.ToLower()))
            .ToList();
    }

    /// Elimina un programa del catálogo por su ID.
    /// Buscamos el objeto por ID y luego usamos Remove() de la lista.
    /// Si buscáramos por Nombre/Versión podríamos eliminar múltiples, pero
    /// usar el ID asegura que eliminamos *exactamente* el registro deseado.
    
    private bool EliminarPorId(int id)
    {
        // Find() busca el primer elemento que cumple la condición.
        var programaAEliminar = catalogo.Find(p => p.Id == id);

        if (programaAEliminar != null)
        {
            // Remove() de la List<T> es eficiente para eliminar un objeto conocido.
            return catalogo.Remove(programaAEliminar);
        }
        return false;
    }

    
    /// Muestra la lista completa de programas registrados.
    /// El bucle 'foreach' es la forma estándar y segura de recorrer colecciones
    /// en C#, asegurando que se procesa cada elemento exactamente una vez.
    
    public void MostrarCatalogoCompleto()
    {
        if (catalogo.Count == 0)
        {
            Console.WriteLine("El catálogo está vacío. Es hora de agregar software");
            return;
        }

        Console.WriteLine("\n--- Catálogo de Software Completo ---");
        // El método ToString() que definimos en la clase ProgramaSoftware se usa aquí.
        foreach (var programa in catalogo)
        {
            Console.WriteLine(programa);
        }
        Console.WriteLine("------------------------------------\n");
    }

    // *********************************************************
    // Métodos de Interfaz de Usuario (Menú y Lógica de Entrada)
    // *********************************************************

    /// Muestra el menú de opciones en la consola.
    /// Es la interfaz principal para que el usuario interactúe con el programa.
    
    public void MostrarMenu()
    {
        Console.WriteLine("\n--- Administración del Catálogo de Software ---");
        Console.WriteLine("1. Agregar nuevo Software ");
        Console.WriteLine("2. Eliminar Software obsoleto (por ID) ");
        Console.WriteLine("3. Buscar Software por Nombre ");
        Console.WriteLine("4. Mostrar Catálogo Completo ");
        Console.WriteLine("5. Salir ");
        Console.Write("Seleccione una opción: ");
    }

    /// Lógica para la opción 1: Agregar Software.
    /// Se encarga de pedir los datos al usuario y manejar la creación del objeto.
    
    private void EjecutarAgregarSoftware()
    {
        Console.WriteLine("\n--- Agregar Nuevo Software ---");
        Console.Write("Nombre del Software (ej: AutoCAD): ");
        string nombre = Console.ReadLine();
        Console.Write("Versión (ej: 2024): ");
        string version = Console.ReadLine();

        // El ID se gestiona automáticamente para evitar duplicados y errores del usuario.
        var nuevoPrograma = new ProgramaSoftware(proximoId++, nombre, version);
        AgregarPrograma(nuevoPrograma);

        Console.WriteLine($" ¡Software '{nombre} v{version}' (ID: {nuevoPrograma.Id}) agregado con éxito!");
    }

    /// Lógica para la opción 2: Eliminar Software.
    /// Requiere que el usuario sepa el ID exacto a eliminar.
    
    private void EjecutarEliminarSoftware()
    {
        MostrarCatalogoCompleto(); // Mostrar el catálogo ayuda a saber qué ID eliminar.
        Console.Write("Ingrese el ID del software obsoleto a ELIMINAR: ");
        if (int.TryParse(Console.ReadLine(), out int idAEliminar))
        {
            if (EliminarPorId(idAEliminar))
            {
                Console.WriteLine($" ¡Software con ID {idAEliminar} eliminado del catálogo!");
            }
            else
            {
                Console.WriteLine($" Error: No se encontró ningún software con el ID {idAEliminar}.");
            }
        }
        else
        {
            Console.WriteLine(" Entrada inválida. Por favor, ingrese un número para el ID.");
        }
    }

    /// Lógica para la opción 3: Buscar Software.
    /// Muestra los resultados o informa si no se encontró nada.
    
    private void EjecutarBuscarSoftware()
    {
        Console.Write("Ingrese el nombre (o parte del nombre) del software a buscar: ");
        string termino = Console.ReadLine();

        var resultados = BuscarSoftwarePorNombre(termino);

        if (resultados.Any()) // La función Any() de LINQ es perfecta para verificar si hay resultados.
        {
            Console.WriteLine($"\n--- Resultados de la búsqueda para '{termino}' ({resultados.Count} encontrados) ---");
            foreach (var programa in resultados)
            {
                Console.WriteLine(programa);
            }
            Console.WriteLine("-----------------------------------------------------------------\n");
        }
        else
        {
            Console.WriteLine($"\n No se encontró software que coincida con '{termino}'.");
        }
    }

    /// 
    /// El bucle principal del programa que gestiona la interacción.
    /// Un bucle 'while(true)' y un 'switch' es el patrón clásico para menús de consola.
    /// 

    public void Ejecutar()
    {
        bool continuar = true;
        while (continuar)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            // Intentamos convertir la entrada a entero para usarla en el switch.
            if (int.TryParse(opcion, out int opcionElegida))
            {
                switch (opcionElegida)
                {
                    case 1:
                        EjecutarAgregarSoftware();
                        break;
                    case 2:
                        EjecutarEliminarSoftware();
                        break;
                    case 3:
                        EjecutarBuscarSoftware();
                        break;
                    case 4:
                        MostrarCatalogoCompleto();
                        break;
                    case 5:
                        Console.WriteLine("¡Gracias por usar el Administrador de Catálogo! ¡Adiós!");
                        continuar = false; // Aquí es donde el bucle se rompe.
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese el número de la opción.");
            }
            // Pequeña pausa para que el usuario pueda leer la salida antes del siguiente menú.
            if (continuar)
            {
                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }

    // ************************
    // Punto de Entrada (Main)
    // ************************
    public static void Main(string[] args)
    {
        // Creamos una instancia de la clase principal para que el programa corra.
        var app = new CatalogoSoftwareApp();
        app.Ejecutar();
    }
}