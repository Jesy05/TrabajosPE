// Descripción: Repetir el ejercicio anterior usando switch con rangos aproximados.

int calificacion;
Console.Write("Ingrese la calificación del estudiante: ");
calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion >= 70)
{
    Console.WriteLine("Aprobado");
}
else if (calificacion >= 50)
{
    Console.WriteLine("Recuperación");
}
else
{
    Console.WriteLine("Reprobado");
}

// Usando switch con rangos aproximados
switch (calificacion / 10) //se usa switch y no if porque permite manejar múltiples casos de manera más clara
// y evita la necesidad de múltiples condiciones
{
    case 7:
    case 8:
    case 9:
    case 10:
        Console.WriteLine("Aprobado");
        break;
    case 5:
    case 6:
        Console.WriteLine("Recuperación");
        break;
    default:
        Console.WriteLine("Reprobado");
        break;
}
