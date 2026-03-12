void edad(int a)
{
    Console.WriteLine($"Su edad es {a}"); ;
}
Console.WriteLine("Ingrese su edad");
Console.WriteLine();
int age=int.Parse(Console.ReadLine());
Console.WriteLine();
if (age>=0)
{ 
edad(age);
}
else
{
    Console.WriteLine("Edad no válida");
}