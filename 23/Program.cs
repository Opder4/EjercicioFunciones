void Suma()
{
    double suma = 0;
    for (int i=1; i<=2; i++)
    {
        Console.WriteLine("Ingrese un número");
        Console.WriteLine();
        double numero=double.Parse(Console.ReadLine());
        Console.WriteLine();
        suma += numero;
    }
    Console.WriteLine($"La suma de los números fue {suma}");
}
Suma();