double preciofinal(double precio, double desc)
{
    return precio - ((precio * desc) / 100);
}
Console.WriteLine("Ingrese el precio del producto");
Console.WriteLine();
double prec = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese el porcentaje (%) del descuento");
Console.WriteLine();
double des = double.Parse(Console.ReadLine());
Console.WriteLine();
if  (prec>=0 && des>=0)
{
    Console.WriteLine($"El precio final es {preciofinal(prec,des)}");
}
else
{
    Console.WriteLine("Los datos no son válidos");
}