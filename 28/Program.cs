void Promedio()
{
    double suma = 0;
    for (int i=1; i<=3; i++)
    {
        Console.WriteLine($"Ingrese la {i}° nota");
        Console.WriteLine();
        double notas = double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (notas>=0 && notas<=100)
        {
            suma += notas;
        }
        else
        { 
            Console.WriteLine("Nota no válida");
        i = i - 1;
        Console.WriteLine();
        }
    }
    Console.WriteLine($"El promedio del estudiante fue {suma/3}");
}
Promedio();