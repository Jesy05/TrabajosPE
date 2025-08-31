// Descripción: Crear un programa que determine si un año es bisiesto usando if y operadores lógicos.

int año; // año es un número entero
Console.Write("Ingrese un año: "); 
año = Convert.ToInt32(Console.ReadLine());

if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0)) // los % son para obtener el residuo de la división
// los || son para "o" lógico, es decir, si se cumple una u otra condición
{
    Console.WriteLine("El año es bisiesto.");
}
else
{
    Console.WriteLine("El año no es bisiesto.");
}
