double AreaTriangulo(double a, double b)
{
    return (a * b) / 2;
}
Console.WriteLine("Ingrese la altura del triángulo");
Console.WriteLine();
double altura = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese la base del triángulo");
Console.WriteLine();
double basse = double.Parse(Console.ReadLine());
Console.WriteLine();
if  (altura>0 && basse>0)
{
    Console.WriteLine($"El área del triángulo es de {AreaTriangulo(altura,basse)} unidades cuadradas");
}
else
{
    Console.WriteLine("Datos no válidos");
}