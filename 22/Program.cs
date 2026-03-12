void Saludo()
{
    Console.WriteLine("Ingrese su nombre");
    Console.WriteLine();
    string nombre=Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine($"¡Hola {nombre}!");
}
Saludo();