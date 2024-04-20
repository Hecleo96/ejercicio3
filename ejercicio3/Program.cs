using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un programa que pida números positivos al usuario, y vaya calculando
            //la suma de todos ellos (terminará cuando se teclea un número negativo o cero (usar Do-While).

            int suma = 0;
            int numero;

            Console.WriteLine("Ingresa un positivo para sumar ó cero ó negativo para terminar: ");

            do
            {
                Console.Write("Ingresa un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    //si el numero es positivo se sumara a la suma total
                    suma += numero;
                }
            }
            while (numero > 0);

            Console.WriteLine("La suma de los números  ingresados es: " + suma);
            Console.ReadKey();
        }
    }
}
