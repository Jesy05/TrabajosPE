// Descripción: Conversor de temperatura con variable global
// Declara una variable global que indique la escala de conversión
// (ejemplo: Celsius a Fahrenheit). Haz un método que use esa variable
// para realizar la conversión.

string escala = "Celsius a Fahrenheit"; // Variable global que define la escala de conversión

void ConvertirTemperatura(double temperatura) // double para permitir decimales, y temperatura es el parámetro
{
    if (escala == "Celsius a Fahrenheit") // si la variable global es igual a esto
    {
        double resultado = (temperatura * 9 / 5) + 32; // fórmula para convertir Celsius a Fahrenheit
        Console.WriteLine("La temperatura en Fahrenheit es: " + resultado); // muestra el resultado
    }
    else if (escala == "Fahrenheit a Celsius") // y si fuera la revezn
    {
        double resultado = (temperatura - 32) * 5 / 9; // fórmula para convertir Fahrenheit a Celsius
        Console.WriteLine("La temperatura en Celsius es: " + resultado);
    }
    else
    {
        Console.WriteLine("Escala de conversión no válida."); // si la variable global no es ninguna de las dos opciones
    }
}

//primero preguntar de que a que se convierte
Console.WriteLine("Escalas disponibles:");
Console.WriteLine("1. Celsius a Fahrenheit");
Console.WriteLine("2. Fahrenheit a Celsius");
Console.Write("Seleccione la escala de conversión (1 o 2): ");
string opcion = Console.ReadLine(); // lee la opción del usuario
if (opcion == "1")
{
    escala = "Celsius a Fahrenheit"; // asigna la variable global
    Console.Write("Ingrese la temperatura a convertir: ");
}
else if (opcion == "2")
{
    escala = "Fahrenheit a Celsius"; // asigna la variable global
    Console.Write("Ingrese la temperatura a convertir: ");
}
else
{
    Console.WriteLine("Opción no válida. Usando la escala por defecto: Celsius a Fahrenheit.");
}

double tempInput = Convert.ToDouble(Console.ReadLine()); // lee la entrada del usuario y la convierte a double
ConvertirTemperatura(tempInput); // Llamada al método con la temperatura ingresada  
