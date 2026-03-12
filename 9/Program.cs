using System.Xml;

double salariofinal(double a, double b)
{
    return a * b;
}
Console.WriteLine("Ingrese su salario por hora");
Console.WriteLine();
double salario = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese las horas trabajadas");
Console.WriteLine();
double horastotales = double.Parse(Console.ReadLine());
Console.WriteLine();
if (horastotales >= 0 && salario>0)
{
    Console.WriteLine($"Su salario final es de Q{salariofinal(salario, horastotales)}");
}
else
{
    Console.WriteLine("Ingrese datos válidos");
}