using System;

class Program
{
    static void Intercambiar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        int a = 3, b = 7;
        Console.WriteLine($"Antes: a={a}, b={b}");

        Intercambiar(ref a, ref b);

        Console.WriteLine($"Después: a={a}, b={b}");
    }
}


 