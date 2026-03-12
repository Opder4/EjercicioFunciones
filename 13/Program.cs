using System.Net.Http.Headers;

double TotalCompras(int a)
{
    double suma = 0;
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine($"Ingrese la {i}° compra") ;
        Console.WriteLine();
        double b=double.Parse( Console.ReadLine() );
        Console.WriteLine();
        if (b>=0)
        { 
        suma += b;
        }
        else
        {
            Console.WriteLine("Precio de compra no válido");
            i = i - 1;
            Console.WriteLine();
        }
    }
        return suma;
}
Console.WriteLine("Ingrese la cantidad de compras que realizó");
Console.WriteLine();
int cantidadcompras=int.Parse( Console.ReadLine() );
Console.WriteLine();
if  ( cantidadcompras>0 )
{
    Console.WriteLine($"El precio total final es Q{TotalCompras(cantidadcompras)}");
}
else
{
    Console.WriteLine("Cantidad de compras no válida");
}