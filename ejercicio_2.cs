using System;

namespace Ejercicio2
{
    internal class ejercicio_2
    {
        public static void Ejercicio2()
        {
            //Tipos de datos mas adecuados para las propiedades de un coche:
            int puertas = 4;
            int ruedas = 4;
            string marca = "Ford";
            bool itvVigente = true;
            Console.WriteLine("---------------------------------" +
                "\nDatos para el auto:" +
                "\nCantidad de puertas: " + puertas +
                "\nCantidad de ruedas: " + ruedas +
                "\nMarca: " + marca +
                "\nTiene ITV vigente?: " + ((itvVigente) ? "Si" : "No") +
                "\n---------------------------------");

            //Tipos de datos mas adecuados para las propiedades de una mesa:
            float peso = 30.4f; //Peso en kg
            float largo = 125.2f; //Largo en cm
            string material = "Madera";
            string color = "Marron";
            Console.WriteLine("---------------------------------" +
                "\nDatos para la mesa:" +
                "\nPeso: " + peso +
                "\nLargo: " + largo +
                "\nMaterial: " + material +
                "\nColor: " + color +
                "\n---------------------------------");
        }
    }
}
