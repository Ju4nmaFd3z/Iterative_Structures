using System;

namespace Ejercicios_Iterativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio7();

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

        // Pide una sola letra y repite hasta que se escriba solo un carácter
        static char LeerLetra(string mensaje)
        {
            string entrada;
            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine() ?? "";
                if (entrada.Length != 1)
                {
                    Console.WriteLine("Escribe solo un carácter.");
                }
            } while (entrada.Length != 1);
            return entrada[0];
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

        // Ejercicio 5: métodos de la clase string
        static void Ejercicio5()
        {
            Console.Write("Introduce una cadena de texto: ");
            string texto = Console.ReadLine() ?? "";

            Console.WriteLine($"Longitud: {texto.Length}");

            Console.Write("Subcadena a buscar: ");
            string busca = Console.ReadLine() ?? "";
            Console.WriteLine($"¿Contiene \"{busca}\"?: {texto.Contains(busca)}");

            char vieja = LeerLetra("Letra a reemplazar: ");
            char nueva = LeerLetra("Letra nueva: ");
            Console.WriteLine($"Texto con el reemplazo: {texto.Replace(vieja, nueva)}");

            Console.WriteLine($"En mayúsculas: {texto.ToUpper()}");
            Console.WriteLine($"En minúsculas: {texto.ToLower()}");

            // Las posiciones empiezan en 0
            int posicion = LeerEntero("Posición del carácter a eliminar: ");
            if (posicion >= 0 && posicion < texto.Length)
            {
                Console.WriteLine($"Texto sin ese carácter: {texto.Remove(posicion, 1)}");
            }
            else
            {
                Console.WriteLine("La posición está fuera del texto.");
            }

            int inicio = LeerEntero("Posición de inicio de la subcadena: ");
            int fin = LeerEntero("Posición de fin de la subcadena: ");
            if (inicio >= 0 && fin < texto.Length && inicio <= fin)
            {
                // Substring pide la longitud, no la posición final
                Console.WriteLine($"Subcadena: {texto.Substring(inicio, fin - inicio + 1)}");
            }
            else
            {
                Console.WriteLine("Las posiciones no son válidas.");
            }
        }

        // Ejercicio 6: factorial de un número
        static void Ejercicio6()
        {
            int numero = LeerEntero("Introduce un número: ");

            if (numero < 0)
            {
                Console.WriteLine("El factorial no existe para números negativos.");
            }
            else if (numero > 20)
            {
                // A partir de 21 el resultado no cabe en un long
                Console.WriteLine("El número es demasiado grande, introduce uno hasta 20.");
            }
            else
            {
                long factorial = 1;
                for (int i = 2; i <= numero; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"El factorial de {numero} es {factorial}");
            }
        }

        // Ejercicio 7: abecedario de la Z a la A
        static void Ejercicio7()
        {
            // El código ASCII de la Z es 90 y el de la A es 65
            for (int codigo = 90; codigo >= 65; codigo--)
            {
                string letra = Convert.ToString((char)codigo);
                Console.Write(letra + " ");
            }
            Console.WriteLine();
        }
    }
}