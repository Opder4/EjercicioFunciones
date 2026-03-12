double ConversionKg(double a)
{
    return  a*2.205;
}
Console.WriteLine("Ingrese el número de Kilogramos (Kg)");
Console.WriteLine();
double kilo=double.Parse(Console.ReadLine());
Console.WriteLine();
if (kilo>=0)
{ 
Console.WriteLine($"La conversión Libras (lb) es {ConversionKg(kilo)} lb");
}
else
{
    Console.WriteLine("Dato inválido");
}