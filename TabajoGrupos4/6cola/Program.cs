// Descripción:  programa que simula una cola de impresión en una oficina

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> colaImpresion = new Queue<string>();
        // establecemos una cola que va a almacenar strings (en este caso los nombres de documentos)
        string documento; // variable para almacenar el nombre del doc
        int opcion; // y la de las opciones del menu

        do // el do while para que el menu se repita hasta que el usuario decida salir
        {
            Console.WriteLine("\n--- COLA DE IMPRESIÓN ---");
            Console.WriteLine("1. Agregar documento");
            Console.WriteLine("2. Mostrar cola de impresión");
            Console.WriteLine("3. Imprimir (Atender primer documento)");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine()); 
            // para manejar la entrada 
            //el int.parse para convertir la entrada de string a entero

            switch (opcion) // el switch para manejar las opciones del menu
            {
                case 1:
                    Console.Write("Ingrese el nombre del documento: ");
                    documento = Console.ReadLine();
                    colaImpresion.Enqueue(documento); // va a agarrar y almacenar el doc al final de la cola
                    Console.WriteLine("Documento agregado a la cola.");
                    break;

                case 2:
                    // Usamos el if para verificar si hay documentos en la cola
                    if (colaImpresion.Count > 0) // aca aplica el first in first out, es decir, 
                    // el primero en entrar es el primero que se va a imprimir las veces que le demos a esa opcion 
                    {
                        Console.WriteLine("\nDocumentos en cola:");
                        foreach (var doc in colaImpresion)
                            Console.WriteLine("- " + doc); //para que se vean organizados
                    }
                    else // es decir <0 o alguna otra cosa
                    {
                        Console.WriteLine("No hay documentos en la cola.");
                    }
                    break;

                case 3:
                    if (colaImpresion.Count > 0)
                    {
                        string docImp = colaImpresion.Dequeue(); //strind docImp que va a almacenar el doc que se va a imprimir
                        Console.WriteLine($"\nImprimiendo: {docImp}");
                    }
                    else
                    {
                        Console.WriteLine("No hay documentos pendientes de impresión.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 4);
         // el while para que el menu se repita hasta que el usuario decida salir
         // si la opcion es diferente de 4 (salir) el menu se va a repetir
         //el != es para "diferente de", en este caso 4, que quiere decir que mientras la opcion 
         // no sea 4, el menu se va a repetir.
    }
}

//la estructura para implementar la cola es similar a la de la pila, pero en lugar de usar Stack<T>, usamos Queue<T>.
// La cola sigue el principio FIFO (First In, First Out), lo que significa que el primer elemento en entrar es el primero en salir.
// Los métodos principales son Enqueue (para agregar un elemento al final de la cola) y Dequeue 
//(para eliminar y devolver el primer elemento de la cola).
//los aspectos importantes para manejar una cola con arreglos son:
//1. Un arreglo para almacenar los elementos de la cola.
//2. Índices o punteros para rastrear la posición del frente y el final de la cola.
//3. Métodos para las operaciones básicas de la cola: Enqueue (encolar)
// y Dequeue (desencolar).
//4. Manejo de condiciones de desbordamiento y subdesbordamiento para evitar errores
// al agregar o quitar elementos.
