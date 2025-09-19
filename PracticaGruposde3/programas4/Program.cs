// Descripcion del programa:Calcular el IVA del 15% y el total a pagar en base a la cantidad y el
// precio unitario de un producto.

using System;
class Ferreteria // Calculo de IVA
{
    static void Main() // Punto de entrada del programa
    {
        int cantidad = 0; // Variable para la cantidad de artículos
        decimal precioUnitario = 0; // Variable para el precio unitario

        // Validar cantidad
        while (true)
        {
            Console.Write(" >>>> Ingrese la cantidad de artículos: "); // Muestra mensaje
            string cantidadInput = Console.ReadLine() ?? ""; // Lee la entrada del usuario, nunca será null
            try
            {
                cantidad = Convert.ToInt32(cantidadInput); // Convierte la entrada a entero
                if (cantidad <= 0)
                {
                    Console.WriteLine("La cantidad debe ser mayor que cero. Intente de nuevo.\n");
                    continue; // Repite el bucle
                }
                break; // Entrada válida, sale del bucle
            }
            catch (FormatException)
            {
                Console.WriteLine(" **** Entrada inválida. Use solo números enteros (ej. 10).*** \n **Intente de nuevo.** ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número demasiado grande o pequeño. Intente un valor razonable.\n");
            }
        }

        // Validar precio unitario
        while (true)
        {
            Console.Write(" >>>>Ingrese el precio unitario: <<<<"); // Muestra mensaje
            string precioInput = Console.ReadLine() ?? ""; // Lee la entrada del usuario, nunca será null
            try
            {
                precioUnitario = Convert.ToDecimal(precioInput); // Convierte la entrada a decimal
                if (precioUnitario <= 0)
                {
                    Console.WriteLine("El precio unitario debe ser mayor que cero. Intente de nuevo.\n");
                    continue; // Repite el bucle
                }
                break; // Entrada válida, sale del bucle
            }
            catch (FormatException)
            {
                Console.WriteLine(" **** Entrada inválida. Use solo números (ej. 199.99).*** \n **Intente de nuevo.** ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Número demasiado grande o pequeño. Intente un valor razonable.\n");
            }
        }

                // Calcular subtotal, IVA y total
                decimal subtotal = cantidad * precioUnitario;
        
                // Calcular IVA (15%)
                decimal iva = subtotal * 0.15m;
        
                // Calcular total a pagar
                decimal total = subtotal + iva;
        
                // Mostrar resultados
                Console.WriteLine($"\nSubtotal: {subtotal:C}");
                Console.WriteLine($"IVA (15%): {iva:C}");
                Console.WriteLine($"Total a pagar: {total:C}");
            } // Cierra el método Main
        } // Cierra la clase Ferreteria