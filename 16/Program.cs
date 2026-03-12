double ConversionMinutos(double m)
{
    return m / 60;
}
Console.WriteLine("Ingrese la cantidad de minutos");
Console.WriteLine();
double minutos=double.Parse(Console.ReadLine());
Console.WriteLine();
if  (minutos >= 0)
{
    Console.WriteLine($"Son {ConversionMinutos(minutos)} hora/s");
}
else
{
    Console.WriteLine("Minutos no válidos");
}