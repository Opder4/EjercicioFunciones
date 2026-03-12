void BirthDay()
{
    Console.WriteLine("Ingrese su edad actual");
    Console.WriteLine();
    int edad=int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (edad>=0)
    {
        Console.WriteLine($"Su año de nacimiento aproximado es {2026-edad}");
    }
    else
    {
        Console.WriteLine("Edad no válida");
    }
}
BirthDay();