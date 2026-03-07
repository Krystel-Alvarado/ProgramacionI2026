using System;

namespace EjerciciosClase
{
    class Program
    {
        // variables globales 
        // para el ejercicio 1
        static string userRegistrado = "";
        static string passRegistrada = "";

        // para el ejercicio 2
        static int puntajeRecord = 100; // le pongo 100 de base para tener algo que superar
        static string jugadorRecord = "CPU";

        static void Main(string[] args)
        {
            // EJERCICIO 1 
            Console.WriteLine("SISTEMA DE USUARIOS");
            RegistrarUsuario();
            Console.WriteLine(); // un salto de linea para que se vea ordenado
            IniciarSesion();

            Console.WriteLine("\n-------------------------\n");

            // EJERCICIO 2
            Console.WriteLine("JUEGO DE PUNTAJES");
            // probamos con alguien que no supera el record
            VerificarPuntaje(80, "Juan"); 
            Console.WriteLine();
            
            // probamos con alguien que si lo supera
            VerificarPuntaje(150, "Maria"); 
            Console.WriteLine();

            // probamos con alguien mas a ver si supera a Maria
            VerificarPuntaje(120, "Pedro");

            Console.ReadKey();
        }

        // metodos del ejercicio 1
        public static void RegistrarUsuario()
        {
            Console.WriteLine("Registro");
            Console.Write("Ingresa un nuevo usuario: ");
            userRegistrado = Console.ReadLine();

            Console.Write("Ingresa tu contrasena: ");
            passRegistrada = Console.ReadLine();

            Console.WriteLine("Usuario registrado con exito!");
        }

        public static void IniciarSesion()
        {
            Console.WriteLine("Login");
            Console.Write("Usuario: ");
            // estas son variables locales
            string userTemp = Console.ReadLine(); 
            
            Console.Write("Contrasena: ");
            string passTemp = Console.ReadLine();

            // upara validar ambas cosas a la vez
            if (userTemp == userRegistrado && passTemp == passRegistrada)
            {
                Console.WriteLine("Login correcto. Bienvenido " + userTemp);
            }
            else
            {
                Console.WriteLine("Error: Usuario o contrasena incorrectos");
            }
        }

        // metodo del ejercicio 2
        public static void VerificarPuntaje(int puntaje, string nombreJugador)
        {
            // verificamos si el puntaje que entro es mayor al global
            if (puntaje > puntajeRecord)
            {
                // actualizamos las globales con los nuevos datos
                puntajeRecord = puntaje;
                jugadorRecord = nombreJugador;

                Console.WriteLine("La nueva puntuacion mas alta es " + puntaje);
                Console.WriteLine("La puntuacion mas alta fue lograda por " + nombreJugador);
            }
            else
            {
                // si no lo supero, mostramos quien tiene el record
                Console.WriteLine("La puntuacion mas alta de " + puntajeRecord + " no se ha podido superar, y aun esta en manos de " + jugadorRecord);
            }
        }
    }
}