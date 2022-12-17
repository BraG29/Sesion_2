using System;
using Ejercicio1;
using Ejercicio2;
using Ejercicio3;

internal class main
{
    static void Main(string[] args)
    {
        int opcion = -1;
        while (opcion != 0)
        {
            Console.Clear();
            Console.WriteLine("Seleccione el ejercicio que quiere ver: " + 
                "\n1. Ejercicio 1" +
                "\n2. Ejercicio 2" +
                "\n3. Ejercicio 3" +
                "\n0. Salir");
            int.TryParse(Console.ReadLine(), out opcion);
            switch(opcion)
            {
                case 0:
                    break;
                case 1:
                    ejercicio_1.Ejercicio1();
                    break;
                case 2:
                    ejercicio_2.Ejercicio2();
                    break;
                case 3:
                    ejercicio_3.Ejercicio3();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción incorrecta intentelo de nuevo por favor\n" +
                        "<Presione enter para continuar>");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
