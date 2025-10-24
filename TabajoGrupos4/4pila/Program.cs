// Descripción: Ejercicio 4: Deshacer Operaciones (Simulación de Undo)

using System;
using System.Collections.Generic;

namespace Ejercicio4_PilaDeshacer
{
    class Program
    {
        static void Main(string[] args) // args puede permanecer vacío porque no se usan argumentos de línea de comandos aca 
        {
            // Declaramos una pila para almacenar las acciones realizadas.
            Stack<string> pilaAcciones = new Stack<string>(); // con el new para que se cree la instancia
            //aca el stack, es decir la pila, va a almacenar strings (acciones)


            Console.WriteLine("=== SIMULACIÓN DE COMANDO 'DESHACER' ===\n");

            // Paso 1 y 2: Permitir al usuario ingresar cinco acciones.
            for (int i = 1; i <= 5; i++) // i es el contador de acciones y se le va sumando 1 hasta llegar a 5
            {
                Console.Write($"Ingrese la acción #{i}: "); // el $ para interpolar la variable i en el string
                                                           // y el # para indicar que es un número ordinal
                string? entrada = Console.ReadLine(); // usamos string? porque puede ser nulo
                string accion = entrada ?? ""; // si es nulo, se reemplaza por una cadena vacía
                                           
                pilaAcciones.Push(accion); // Guardamos la acción en la pila
            }

            // Paso 3: Mostrar todas las acciones almacenadas.
            Console.WriteLine("\nAcciones almacenadas en la pila:");
            MostrarPila(pilaAcciones);

            // Paso 4: Simular la acción “Deshacer”.
            Console.WriteLine("\n--- Simulando 'Deshacer' ---");
            if (pilaAcciones.Count > 0)
            {
                string ultimaAccion = pilaAcciones.Pop(); // Quitamos la última acción
                Console.WriteLine($"Acción deshecha: {ultimaAccion}");
            }
            else
            {
                Console.WriteLine("No hay acciones para deshacer.");
            }

            // Paso 5: Mostrar el estado actual de la pila después del deshacer.
            Console.WriteLine("\nPila después de deshacer:");
            MostrarPila(pilaAcciones);

            // Paso 6: Indicar si la pila está vacía.
            if (pilaAcciones.Count == 0)
            {
                Console.WriteLine("\nNo hay más acciones por deshacer. La pila está vacía.");
            }
            else
            {
                Console.WriteLine($"\nAún quedan {pilaAcciones.Count} acciones que se podrían deshacer.");
            }

            Console.WriteLine("\nPrograma finalizado. Presione una tecla para salir...");
            Console.ReadKey();
        }

        // Método auxiliar para mostrar el contenido actual de la pila.
        static void MostrarPila(Stack<string> pila) // aca afuera para que el main no quede tan largo
        {
            if (pila.Count == 0)
            {
                Console.WriteLine("La pila está vacía.");
            }
            else
            {
                // Recorremos e imprimimos las acciones en orden
                foreach (string accion in pila)
                {
                    Console.WriteLine("- " + accion); // usamos el foreach para poner ese guion antes de cada accion
                }
            }
        }
    }
}

// la estructura de la pila es LIFO (Last In, First Out),
// es decir, la última acción ingresada es la primera en ser deshecha.
// Esta lógica es para usarse en aplicaciones como editores de texto, donde el usuario puede deshacer sus últimas acciones.
// El programa guía al usuario a través de la simulación, mostrando claramente el estado de la pila en cada paso.
//La estructura para usar la pila con arreglos es similar a la de las listas enlazadas,
//pero con diferencias en la implementación interna.
//Los elementos importantes para manejar una pila con arreglos son:
//1. Un arreglo para almacenar los elementos de la pila.    
//2. Un índice o puntero para rastrear la posición del tope de la pila.
//3. Métodos para las operaciones básicas de la pila: Push (apilar), Pop
//   (desapilar) y Peek (ver el tope sin quitarlo).
//4. Manejo de condiciones de desbordamiento (overflow) y subdesbordamiento
//   (underflow) para evitar errores al agregar o quitar elementos.