// Descripción: Escriba el programa que lea números del teclado mientras no se digite -99 
// Determinar el mayor y el menor de los números  que fueron ingresados.

int numero;
int mayor = int.MinValue;
int menor = int.MaxValue;

Console.WriteLine("Ingrese números (-99 para terminar):");

while (true)
{
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero == -99)
    {
        break;
    }

    if (numero > mayor)
    {
        mayor = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }
}

if (mayor != int.MinValue && menor != int.MaxValue)
{
    Console.WriteLine("El número mayor ingresado es: " + mayor);
    Console.WriteLine("El número menor ingresado es: " + menor);
}
else
{
    Console.WriteLine("No se ingresaron números válidos.");
}
