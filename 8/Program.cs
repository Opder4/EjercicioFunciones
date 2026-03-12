double promedio(double suma)
{
    return (suma) / 3;
}
double suma = 0;
for (int i=1; i<=3; i++)
{
    Console.WriteLine($"Ingrese el {i}° número");
    Console.WriteLine();
    double num = double.Parse(Console.ReadLine());
    Console.WriteLine();
    suma += num;
}
Console.WriteLine($"La el promedio de los tres fue {promedio(suma)}");
