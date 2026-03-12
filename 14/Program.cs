double VelocidadPromedio(double a, double b)
{
    return a / b;
}
Console.WriteLine("Ingrese la distancia recorridad por el emprealdo ");
Console.WriteLine();
double distancia = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese el tiempo hecho por el emprealdo ");
Console.WriteLine();
double tiempo = double.Parse(Console.ReadLine());
Console.WriteLine();
if (distancia>=0 && tiempo>0)
{
    Console.WriteLine($"La velocidad promedio del empleado es de {VelocidadPromedio(distancia, tiempo)} m/s");
}
else
{
    Console.WriteLine("Datos no válidos");
}