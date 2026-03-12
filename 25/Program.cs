void AreaRectangulo()
{
    Console.WriteLine("Ingrese la altura del rectangulo");
    Console.WriteLine();
    double altura=double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Ingrese la base del rectangulo");
    Console.WriteLine();
    double basee = double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (altura>0 && basee>0)
    {
        Console.WriteLine($"El área del rectáguno es {basee*altura} unidades cuadradas");
    }
    else
    {
        Console.WriteLine("Datos no válidos");
    }
}
AreaRectangulo();