void AreaCirculo()
{
    Console.WriteLine("Ingrese el Radio (r) del círculo");
    Console.WriteLine();
    double radio = double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (radio <= 0)
    {
        Console.WriteLine("Dato no válido");
    }
    else
    {
        Console.WriteLine($"El área del círculo es {(radio*radio)*Math.PI}");
    }
}
AreaCirculo();
