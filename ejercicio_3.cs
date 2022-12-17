using System;

namespace Ejercicio3;

public class ejercicio_3
{
    public static void Ejercicio3()
    {
        int numero = 20;
        char caracter = 'a';
        Console.WriteLine("Valor de numero: " + numero +
            "\nValor de caracter: " + caracter);
        Console.WriteLine("El numero es mayor o igual a 18? -> "
            + (numero >= 18));
        Console.WriteLine("El caracter es 'a'? -> " +
            (caracter == 'a'));
        Console.WriteLine("Se cumple que numero sea mayor a 18 y caracter igual a? -> " +
            ((numero > 18) && (caracter == 'a')));
        Console.WriteLine("Se cumple que numero sea menor a 18 o caracter igual a? -> " +
            ((numero < 18) || (caracter == 'a')));
    }
}
