// Descripción: Pedir un número entre 1 y 7 y mostrar el día de la semana con switch.

int dia;
Console.Write("Ingrese un número del 1 al 7: ");
dia = Convert.ToInt32(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miércoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Número inválido. Ingrese un número del 1 al 7.");
        break;
}