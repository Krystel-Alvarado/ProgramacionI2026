Console.WriteLine("Ingrese un numero entero");

int numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }
    Console.WriteLine(i);
}
