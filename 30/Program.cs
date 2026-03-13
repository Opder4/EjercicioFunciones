using System.ComponentModel.Design;

void Reporte()
{
    Console.WriteLine("Ingrese el nombre del estudiante");
    Console.WriteLine();
    string nombre=Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Ingrese el curso del estudiante");
    Console.WriteLine();
    string curso=Console.ReadLine();
    Console.WriteLine();
    double suma = 0;
    for (int i=1; i<=3; i++)
    {
        Console.WriteLine($"Ingrese la {i}° calificación");
        Console.WriteLine();
        double notas=double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (notas>=0 && notas<=100)
        {
            suma += notas;
        }
        else
        {
            Console.WriteLine("Dato inválido");
            i = i - 1;
            Console.WriteLine();
        }
    }
    Console.WriteLine($"El nombre del estudiante es {nombre}");
    Console.WriteLine();
    Console.WriteLine($"El curso del estudiante es {curso}");
    Console.WriteLine();
    Console.WriteLine($"Su promedio es {suma/3}");
}
Reporte();