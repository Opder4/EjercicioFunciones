double suma(double a, double b)
{
    return a + b;
}
Console.WriteLine("Ingrese el primer número");
Console.WriteLine();
double a = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("ingrese el segundo número");
Console.WriteLine();
double b = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"La suma es {suma(a,b)}");