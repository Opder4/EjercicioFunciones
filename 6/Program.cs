double conversionFh(double a)
{
    return (a*(9/5))+35;
}
Console.WriteLine("Ingrese la cantidad de Celsius");
Console.WriteLine();
double a = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"La conversión a F° es {conversionFh(a)}");