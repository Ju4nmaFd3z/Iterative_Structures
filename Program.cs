using System;

namespace Ejercicios_Iterativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio4();

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

        // Pide un entero y repite hasta que sea válido
        static int LeerEntero(string mensaje)
        {
            int numero;
            bool esValido;
            do
            {
                Console.Write(mensaje);
                esValido = int.TryParse(Console.ReadLine(), out numero);
                if (!esValido)
                {
                    Console.WriteLine("Entrada no válida. Introduce un número entero.");
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

        // Ejercicio 2: factura de la luz
        static void Ejercicio2()
        {
            // Tramos y precios por kilovatio
            const double LIMITE_ALTO = 1800;
            const double LIMITE_BAJO = 1000;
            const double PRECIO_ALTO = 0.8;
            const double PRECIO_MEDIO = 0.12;
            const double PRECIO_BAJO = 0.14;

            double consumo = LeerDecimal("Kilovatios consumidos: ");

            if (consumo < 0)
            {
                Console.WriteLine("El consumo no puede ser negativo.");
                return;
            }

            double precio;
            if (consumo > LIMITE_ALTO)
            {
                precio = PRECIO_ALTO;
            }
            else if (consumo >= LIMITE_BAJO)
            {
                precio = PRECIO_MEDIO;
            }
            else
            {
                precio = PRECIO_BAJO;
            }

            double total = consumo * precio;
            Console.WriteLine($"Total a pagar: {total:F2}€");
        }

        // Ejercicio 3: estado civil con switch
        static void Ejercicio3()
        {
            Console.Write("Introduce tu estado civil (C, S, V o D): ");
            // Pasamos a mayúsculas para aceptar también minúsculas
            string estado = (Console.ReadLine() ?? "").ToUpper();

            switch (estado)
            {
                case "C":
                    Console.WriteLine("Tu estado civil es Casad@");
                    break;
                case "S":
                    Console.WriteLine("Tu estado civil es Solter@");
                    break;
                case "V":
                    Console.WriteLine("Tu estado civil es Viud@");
                    break;
                case "D":
                    Console.WriteLine("Tu estado civil es Divorciad@");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Usa C, S, V o D.");
                    break;
            }
        }

        // Ejercicio 4: tabla de multiplicar
        static void Ejercicio4()
        {
            int numero;
            do
            {
                numero = LeerEntero("Introduce un número del 1 al 9: ");
                if (numero < 1 || numero > 9)
                {
                    Console.WriteLine("El número está fuera de rango.");
                }
            } while (numero < 1 || numero > 9);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}