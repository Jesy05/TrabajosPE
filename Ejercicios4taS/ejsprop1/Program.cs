// Descripción:  Contador de accesos global
// Declara una variable global que almacene el número de veces que
// se ha ejecutado un método. Cada vez que se llame al método, debe
// incrementar el contador y mostrarlo en pantalla.

int contador = 0; // Variable global para contar las llamadas al método

void ContarAccesos() // Método que cuenta y muestra las veces que ha sido llamado
{
    contador++; // Incrementa el contador en 1
    Console.WriteLine("El método ha sido llamado " + contador + " veces.");
}

// Llamadas de prueba al método
ContarAccesos();
ContarAccesos();
ContarAccesos(); // esto prueba que la variable global funciona porque se puede llamar fuera del método 