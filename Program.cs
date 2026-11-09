using System;

namespace Ejercicios_Iterativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey();
        }

        // Pide un número con decimales y repite hasta que sea válido
        static double LeerDecimal(string mensaje)
        {
            double numero;
            bool esValido;
            do
            {
                Console.Write(mensaje);
                esValido = double.TryParse(Console.ReadLine(), out numero);
                if (!esValido)
                {
                    Console.WriteLine("Entrada no válida. Introduce un número.");
                }
            } while (!esValido);
            return numero;
        }

        // Ejercicio 1: cuál de dos números es mayor
        static void Ejercicio1()
        {
            double numero1 = LeerDecimal("Introduce el primer número: ");
            double numero2 = LeerDecimal("Introduce el segundo número: ");

            // Si son iguales no hay mayor
            if (numero1 == numero2)
            {
                Console.WriteLine("Los dos números son iguales.");
            }
            else
            {
                Console.WriteLine($"El número mayor es {Math.Max(numero1, numero2)}");
            }
        }
    }
}