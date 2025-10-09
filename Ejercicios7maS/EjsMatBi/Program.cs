// Este es un ejemplo de una matriz bidimencional 

using System;
namespace EjsMatBi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 0, 0, 0, 0 }, { 9, 10, 11, 12 } };

            Console.WriteLine("Matriz bidimensional:");

            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            // Mostrar la matriz separada de la suma de cada fila
            for (int i = 0; i < filas; i++) 
            {
                int sumaFila = 0;
                // Este for anidado recorre las columnas
                // y muestra los elementos de cada fila con \t
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                    sumaFila += matriz[i, j];
                }
                Console.WriteLine("Suma de la fila " + (i + 1) + ": " + sumaFila);
            }
||||||
            // Calcular y mostrar la suma de cada columna
            Console.WriteLine();
            Console.WriteLine("Suma por columnas:");
            for (int j = 0; j < columnas; j++)
            {
                int sumaColumna = 0;
                for (int i = 0; i < filas; i++)
                {
                    sumaColumna += matriz[i, j];
                }
                Console.WriteLine("Suma de la columna " + (j + 1) + ": " + sumaColumna);
            }
        }
    }
} 

// cual es el ciclo para mostrar los datos de los arreglos bidimensionales?
// for anidado