int suma = 0;
int cantidad = 0;

while (true)
{
    Console.WriteLine("Ingrese una nota entre 1 y 10 (o escriba 'fin'): ");
    string entrada = Console.ReadLine();

    if (entrada.ToLower() == "fin")
    {
        break;
    }

    if (int.TryParse(entrada, out int nota))
    {
        if (nota >= 1 && nota <= 10)
        {
            suma += nota;
            cantidad++;
        }
        else
        {
            Console.WriteLine("La nota debe estar entre 1 y 10.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no valida.");
    }
}

if (cantidad > 0)
{
    double promedio = (double)suma / cantidad;
    Console.WriteLine("El promedio es: " + promedio);
}
else
{
    Console.WriteLine("No se ingresaron notas.");
}


