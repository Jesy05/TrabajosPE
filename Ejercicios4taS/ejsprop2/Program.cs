// Descripción:  Área de un rectángulo con variables locales
// Crea un método que pida la base y altura de un rectángulo, use
// variables locales para calcular el área y la imprima en pantalla.

void CalcularAreaRectangulo() 
{
    Console.Write("Ingrese la base del rectángulo: ");
    double baseRectangulo = Convert.ToDouble(Console.ReadLine()); //aca la primera variable local
                                                                  // la variable baseRectangulo es local 
                                                                  // al método CalcularAreaRectangulo y no puede
                                                                  // ser utilizada fuera de este método
    

    Console.Write("Ingrese la altura del rectángulo: ");
    double alturaRectangulo = Convert.ToDouble(Console.ReadLine());

    double area = baseRectangulo * alturaRectangulo;
    Console.WriteLine("El área del rectángulo es: " + area);
}

CalcularAreaRectangulo(); // Llamada al método para ejecutar el cálculo del área