// Descripción: Evaluar la calificación de un estudiante y mostrar si aprobó (≥70), recuperación (50–69) o reprobó (<50) con if.

int calificacion;
Console.Write("Ingrese la calificación del estudiante: ");
calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion >= 70)
{
    Console.WriteLine("El estudiante aprobó.");
}
else if (calificacion >= 50 && calificacion <= 69)
{
    Console.WriteLine("El estudiante está en recuperación.");
}
else
{
    Console.WriteLine("El estudiante reprobó.");
}
