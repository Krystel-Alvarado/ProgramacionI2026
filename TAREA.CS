using System;

namespace EjerciciosCSharp
{
    class SolucionEjercicios
    {
        static void Main(string[] args)
        {
            // ejercicio 1
            CalcularIngresos();

            // ejercicio 2
            SolucionEjercicios operaciones = new SolucionEjercicios();
            
            int numero1 = 20;
            int numero2 = 5;
            
            Console.WriteLine($"Suma: {operaciones.Sumar(numero1, numero2)}");
            Console.WriteLine($"Resta: {operaciones.Restar(numero1, numero2)}");
            Console.WriteLine($"Multiplicacion: {operaciones.Multiplicar(numero1, numero2)}");
            Console.WriteLine($"Division: {operaciones.Dividir(numero1, numero2)}");

            // ejercicio 3 (try catch)
            SumarSeguro();

            Console.ReadKey();
        }

        public static void CalcularIngresos()
        {
            Console.Write("Introduce tu nombre: ");
            string nombre = Console.ReadLine();

            double suma = 0;
            
            // pidiendo los 3 meses
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Ingresos del mes {i}: ");
                suma += double.Parse(Console.ReadLine());
            }

            double promedio = suma / 3.0;
            
            Console.WriteLine($"Hola {nombre} en total ganaste {suma} y promediaste {promedio}");
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir entre cero");
                return 0; 
            }
            return a / b;
        }

        public static void SumarSeguro()
        {
            Console.Write("Primer valor: ");
            string valor1 = Console.ReadLine();
            
            Console.Write("Segundo valor: ");
            string valor2 = Console.ReadLine();

            try
            {
                // pasamos de texto a numero
                int num1 = int.Parse(valor1);
                int num2 = int.Parse(valor2);
                
                int resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
            }
            catch (FormatException)
            {
                // error por si meten letras o lo dejan vacio
                Console.WriteLine("Error: Tienen que ser numeros enteros");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Numero muy grande");
            }
            finally
            {
                // siempre se ejecuta al final
                Console.WriteLine("Termino el bloque try-catch");
            }
        }
    }
}