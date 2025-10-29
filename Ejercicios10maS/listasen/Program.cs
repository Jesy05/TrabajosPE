using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definimos e inicializamos la lista de cadenas.
            List<string> lista = new List<string>();
            bool continuar = true;

            Console.WriteLine("--- Programa de Gestión de Lista (C#) ---");

            while (continuar)
            {
                // Menú de opciones
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Eliminar elemento");
                Console.WriteLine("3. Mostrar elementos (opcional, para verificar)");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine("----------------");

                switch (opcion)
                {
                    // Caso 1: Agregar elemento
                    case "1":
                        Console.Write("Ingrese el elemento a agregar: ");
                        string elementoAgregar = Console.ReadLine();

                        // Usamos el método Add() para insertar el elemento.
                        lista.Add(elementoAgregar);
                        Console.WriteLine($"'{elementoAgregar}' agregado a la lista.");
                        break;

                    // Caso 2: Eliminar elemento
                    case "2":
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía. No hay elementos para eliminar.");
                            break;
                        }

                        Console.Write("Ingrese el elemento a eliminar: ");
                        string elementoEliminar = Console.ReadLine();

                        // Usamos el método Remove(). Devuelve 'true' si lo elimina.
                        bool eliminado = lista.Remove(elementoEliminar);

                        if (eliminado)
                        {
                            Console.WriteLine($"'{elementoEliminar}' ha sido eliminado de la lista.");
                        }
                        else
                        {
                            Console.WriteLine($"'{elementoEliminar}' no se encontró en la lista.");
                        }
                        break;

                    // Caso 3: Mostrar elementos
                    case "3":
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        else
                        {
                            Console.WriteLine("Elementos en la Lista:");
                            // Usamos un bucle foreach para recorrer e imprimir cada elemento.
                            foreach (var item in lista)
                            {
                                Console.WriteLine($"- {item}");
                            }
                        }
                        break;

                    // Caso 4: Salir
                    case "4":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    // Opción por defecto para entradas no válidas
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}

// en los nodos la lista la guia un elemento, a partir de ese elemento se puede acceder al siguiente y asi sucesivamente.
// al final de la lista el siguiente es null.
// para agregar un elemento se crea un nuevo nodo y se enlaza al final de la lista

//una estructura de datos es una forma de organizar y almacenar datos en la memoria de una computadora de manera eficiente para facilitar su acceso y manipulación.

// arreglos lineales o dinamicos: listas, pilas, colas, listas enlazadas
// arreglos no lineales: arboles, grafos

// el nodo esta conformado de dos partes: el dato y la referencia al siguiente nodo 
// un valor y dos campos, uno para el dato y otro para la referencia al siguiente nodo.
// recursividad: una funcion que se llama a si misma hasta llegar a un caso base nos da la respuesta deseada.
// y eso se va guardando en la pila de llamadas hasta llegar al caso base y luego se van resolviendo las llamadas pendientes.

// nodo sin hijos es una hoja
// nodo con hijos es un padre

// depende de la estructura y no hay un limite fijo de niveles 

// el numero de nodos es el peso del arbol
// el orden de un arbol es la cantidad maxima de hijos que puede tener un nodo

// hay diferentes tipos de arboles: binarios, AVL, B, B+, etc.
// los arboles binarios son aquellos en los que cada nodo puede tener hasta dos hijos, uno izquierdo y uno derecho.
// son de orden 2 max de hijos por nodo
// un arbol binario de busqueda es un arbol binario en el que para cada nodo, los valores de los nodos en el subarbol izquierdo son menores que el valor del nodo padre, y los valores de los nodos en el subarbol derecho son mayores.
// la raiz es el primer elemento que leamos  


// los arboles AVL son arboles binarios de busqueda auto-balanceados
// los arboles B y B+ son arboles balanceados de busqueda que permiten almacenar grandes cantidades de datos en disco.

// el orden de los recorridos es: preorden, inorden, postorden, es decir, primero se visita el nodo padre, luego el hijo izquierdo y luego el hijo derecho.