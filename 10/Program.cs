using System.Threading.Channels;

double cubo(double a)
{
    return a * a * a ;
}
Console.WriteLine("Ingrese un número");
Console.WriteLine();
double numero = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"El cubo del número es {cubo(numero)}");