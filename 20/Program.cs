    double SalarioFinal(double a, double b)
    {
        return a * b;
    }
    Console.WriteLine("Ingrese su salario diario");
    Console.WriteLine();
    double salario = double.Parse(Console.ReadLine());
    Console.WriteLine();
    if (salario > 0)
    {
        Console.WriteLine("Ingrese los días trabajados");
        Console.WriteLine();
        double diastotales = double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (diastotales >= 0)
        {
            Console.WriteLine($"Su salario final es Q{SalarioFinal(salario, diastotales)}");
        }
        else
        {
            Console.WriteLine("Dato no válido");
        }
    }
    else
    {
        Console.WriteLine("Salario no válido");
    }
