using System;
using System.Linq; // Necesario para usar string.Join()

public class InsertionSortDemo
{
    public static void Main(string[] args)
    {
        int[] arreglo = { 41, 21, 9, 6, 11, 20 }; // nuestro arreglo de ejemplo desordenado para iniciar 

        Console.WriteLine("--- DEMOSTRACIÓN DE INSERTION SORT ---");
        Console.WriteLine($"Arreglo inicial: [{string.Join(", ", arreglo)}]\n");

        InsertionSort(arreglo);

        Console.WriteLine("\n--- ORDENAMIENTO COMPLETADO ---");
        Console.WriteLine($"Arreglo final: [{string.Join(", ", arreglo)}]");
    }

    /// aca ya implementamos el algoritmo Insertion Sort, ordenando el arreglo 'arr' in-place, 
    /// que sirve para ordenar un arreglo de enteros en orden ascendente.

    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length; // Longitud del arreglo

        // Bucle externo: Itera desde el segundo elemento (arr[1]). 
        // El primer elemento (arr[0]) se asume como sublista ordenada inicial.
        for (int i = 1; i < n; i++)
        {
            // La 'clave' es el valor que vamos a insertar en la sublista ordenada [0...i-1].
            int clave = arr[i];
            
            // 'j' es el índice del último elemento de la sublista ya ordenada.
            int j = i - 1;

            Console.WriteLine($"\n--- Paso {i}: Insertando {clave} (índice {i}) ---");
            Console.WriteLine($"  Arreglo actual antes de mover: [{string.Join(", ", arr)}]");

            // Bucle interno: Retrocede en la sublista ordenada.
            // Mueve elementos a la derecha si son mayores que la "clave"
            while (j >= 0 && arr[j] > clave)
            {
                // Desplazamiento: Mueve el elemento de arr[j] a arr[j+1].
                Console.WriteLine($"  -> Desplazando {arr[j]} de arr[{j}] a arr[{j + 1}]");
                arr[j + 1] = arr[j];
                
                // Retrocede al siguiente elemento en la subliste.
                j = j - 1;
            }

            // Inserción: Coloca la 'clave' en el hueco encontrado (j + 1).
            // NOTA: 'j' se decrementó por última vez DENTRO del bucle. Si el bucle terminó, 
            // el punto de inserción correcto es siempre la posición siguiente (j + 1).
            arr[j + 1] = clave;
            
            Console.WriteLine($"  -> Clave {clave} insertada en arr[{j + 1}].");
            Console.WriteLine($"  -> Estado del arreglo: [{string.Join(", ", arr)}]");
        }
    }
}