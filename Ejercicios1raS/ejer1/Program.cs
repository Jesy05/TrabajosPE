// Descripción: Este programa para determinar si un número ingresado es positivo, negativo o cero usando if.

int num; 
Console.Write("Ingrese un número: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("El número es positivo.");
}
else if (num < 0) // es un condicional doble o compuesto 
{
    Console.WriteLine("El número es negativo.");
}
else
{
    Console.WriteLine("El número es cero.");
}

