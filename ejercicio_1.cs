using System;

namespace Ejercicio1
{
    public class ejercicio_1
    {
        public static void Ejercicio1()
        {
            string nombre, apellido;
            int edad;
            bool? sabeProgramar = null;
            Console.WriteLine("Bienvenido.\n" +
                "Por favor ingrese los datos que se le pedira a continuación..." +
                "\n<Presione enter para continuar>");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Clear();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Clear();
            do
            {
                Console.Write("Edad: ");
                //Uaso el metodo TryParse para que devuelva false si lo ingresado no es un número entero
                if(int.TryParse(Console.ReadLine(), out edad))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("La edad ingresada NO es correcta. " +
                        "Por favor intentelo de nuevo");
                }

            }while(true);
            Console.Clear();

            do
            {
                Console.Write("Sabe usted programar? (s/n) ");
                string confirmacion = Console.ReadLine();
                //Para este caso usamos un switch para controlar rapidamente si 
                //el caracter ingresado no es correcto
                switch (confirmacion)
                {
                    case "s":
                        sabeProgramar = true;
                        break;
                    case "n":
                        sabeProgramar = false;
                        break;
                    default:
                        Console.WriteLine("La opcion no es correcta. Por favor intentelo de nuevo: " +
                            "\n<Presion enter para continuar");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (sabeProgramar == null);

        }
    }
}
