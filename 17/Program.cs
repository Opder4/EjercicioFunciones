double PromedioGrupo(int a)
{
    double suma = 0;
    for (int i=1; i<=a; i++)
    {
        Console.WriteLine($"Ingrese la nota del {i}° estudiante");
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
    return suma/a;
}
Console.WriteLine("Ingrese la cantidad de estudiantes");
Console.WriteLine();
int cantidadestudiante=int.Parse(Console.ReadLine());
Console.WriteLine();
if (cantidadestudiante>0)
{
    Console.WriteLine($"El promedio del grupo fue de {PromedioGrupo(cantidadestudiante)}");
}
else
{
    Console.WriteLine("Dato no váldio");
}