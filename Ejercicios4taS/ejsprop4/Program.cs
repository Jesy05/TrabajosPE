// Descripción: Suma acumulada con variable global
// Declara una variable global sumaTotal. Cada vez que el usuario
// ingrese un número (en un método), se debe sumar al acumulado y
// mostrar el total actualizado.

int sumaTotal = 0; // Variable global para almacenar la suma acumulada
// un bucle para que el usuario siga ingresando números hasta que quiera salir
while (true)
{
    SumarNumero(); // Llama al método para sumar un número
    Console.Write("¿Desea ingresar otro número? (s/n): ");
    string respuesta = Console.ReadLine() ?? ""; // Lee la respuesta del usuario
    if (respuesta.ToLower() != "s") // Si la respuesta no es 's', sale del bucle
    {
        break;
    }
}
void SumarNumero() // Método que pide un número, lo suma al total y muestra el resultado
{
    Console.Write("Ingrese un número para sumar al total: ");
    int numero = Convert.ToInt32(Console.ReadLine()); // Lee el número ingresado por el usuario
    sumaTotal += numero; // Suma el número al acumulado global
    Console.WriteLine("La suma total actualizada es: " + sumaTotal); // Muestra la suma total actualizada
}

// Llamadas de prueba al método
SumarNumero();