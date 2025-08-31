// Descripción: recorre los números del 1 al 100 con un bucle for, 
// separa los pares e impares usando el operador módulo %, acumula 
// cada grupo en variables distintas (sumapar y sumaimpar) y al final 
// muestra en pantalla la suma total de los números pares y la suma total de los números impares.

int sumapar = 0;
int sumaimpar = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        sumapar += i;
    }
    else
    {
        sumaimpar += i;
    }
}

Console.WriteLine("Suma total de números pares: " + sumapar);
Console.WriteLine("Suma total de números impares: " + sumaimpar);