void CantidadEstudiantes()
{
    Console.WriteLine("Ingrese la cantidad de estudiantes en el curso");
    Console.WriteLine();
    int cantidadestudiantes=int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (cantidadestudiantes>=0)
    {
        Console.WriteLine($"Hay {cantidadestudiantes} estudiantes en el curso");
    }
    else
    {
        Console.WriteLine("Cantidad no válida");
    }
}
CantidadEstudiantes();