double PromedioGrupo(string a)
{
    double suma = 0;
    for (int i = 1; i <= 3; i++)
    {
        Console.WriteLine($"Ingrese la {i}° nota  del estudiante");
        Console.WriteLine();
        double notas = double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (notas >= 0 && notas <= 100)
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
    return suma / 3;
}
Console.WriteLine("Ingrese el nombre del estudiante estudiante");
Console.WriteLine();
string nombreestudiante =Console.ReadLine();
Console.WriteLine();
    Console.WriteLine($"El promedio de {nombreestudiante} fue de {PromedioGrupo(nombreestudiante)}");
