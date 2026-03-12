using System.Threading.Channels;

double doble(double a)
{
    return 2*a;
}
Console.WriteLine("Ingrese un número");
Console.WriteLine();
double a = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"El doble es {doble(a)}");