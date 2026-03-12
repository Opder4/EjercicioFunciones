void PrecioFinal()
{
    Console.WriteLine("Ingrese el precio de un producto");
    Console.WriteLine();
    double precio=double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (precio >= 0 )
    {
        Console.WriteLine($"El precio con 10% de descuento es {precio-(precio*0.10)}");
    }
    else
    {
        Console.WriteLine("Precio no válido");
    }
}
PrecioFinal();