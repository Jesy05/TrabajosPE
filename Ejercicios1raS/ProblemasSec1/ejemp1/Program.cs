// Descripción: Desarrolle un programa que calcule el monto total a pagar por la compra de una cantidad específica de un producto, donde el precio por unidad se proporciona como una variable de entrada desconocida ingresada por el usuario.

decimal precioPorUnidad;
int cantidad;
decimal montoTotal;

Console.Write("Ingrese el precio por unidad del producto: ");
precioPorUnidad = Convert.ToDecimal(Console.ReadLine());

Console.Write("Ingrese la cantidad de productos a comprar: ");
cantidad = Convert.ToInt32(Console.ReadLine());

montoTotal = precioPorUnidad * cantidad;

Console.WriteLine("El monto total a pagar es: " + montoTotal);