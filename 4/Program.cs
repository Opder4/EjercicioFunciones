double areacirculo(double a)
{
    return a * Math.PI;
}
Console.WriteLine("Ingrese el Radio (r) del círculo");
Console.WriteLine();
double a=double.Parse(Console.ReadLine());
Console.WriteLine();
if (a<=0)
{
    Console.WriteLine("Ingrese un Radio (r) válido");
}
else
{
    Console.WriteLine($"El área del círculo es {areacirculo(a)}");
}