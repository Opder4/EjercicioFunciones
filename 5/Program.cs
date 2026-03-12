using System.Threading.Channels;

double arearec(double a, double b)
{
    return a * b;
}
Console.WriteLine("Ingrese la altura del rectángulo");
Console.WriteLine();
double a = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese la base del rectángulo");
Console.WriteLine();
double b = double.Parse(Console.ReadLine());
Console.WriteLine();
if  (a<0 || b<0)
{
    Console.WriteLine("Ingrese datos válidos");
}
else
{
    Console.WriteLine($"El área del rectángulo es {arearec(a,b)}");
}