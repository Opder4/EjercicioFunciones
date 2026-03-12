double cuadrado(double a)
{
    return a * a;
}
Console.WriteLine("Ingrese un número");
Console.WriteLine();
double a = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"El cuadrado es {cuadrado(a)}");