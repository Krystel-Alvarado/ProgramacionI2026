Console.WriteLine("Hola! Ingrese un numero entero positivo:");

int numero = int.Parse(Console.ReadLine());

bool esPrimo = true;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        esPrimo = false;
        break;
    }
}
if (esPrimo)
{
    Console.WriteLine("Este numero es primo");
}
else
{
    Console.WriteLine("Este numero no es primo");
}