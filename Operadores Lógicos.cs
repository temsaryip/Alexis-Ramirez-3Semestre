using System;

namespace MySolution;

class Program
{
    static void Main(string[] args)
    {
        //operadores aritmeticos
        /*
        + = suma
        - = resta
        * = multiolicacion
        / = division
        % = modulo
        */
        /*double NumeroUno = 15;
        double NumeroDos = 30;
        Console.WriteLine(NumeroUno+NumeroDos);
        Console.WriteLine(NumeroUno-NumeroDos);
        Console.WriteLine(NumeroUno*NumeroDos);
        Console.WriteLine(NumeroUno/NumeroDos);
        Console.WriteLine(NumeroUno%NumeroDos);
        Console.WriteLine(NumeroDos%NumeroUno);
        */
        
        // Círculo
        Console.WriteLine("Introduce el radio: ");
        double c1 = double.Parse(Console.ReadLine());
        double a = 3.1416 * (c1 * c1);
        Console.WriteLine("Área del círculo: " + a);

        // Cuadrado
        Console.WriteLine("Introduce el lado: ");
        double l1 = double.Parse(Console.ReadLine());
        double b = l1 * l1;
        Console.WriteLine("Área del cuadrado: " + b);

        // Rectangulo
        Console.WriteLine("Introduce la base: ");
        double T1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Introduce la altura: ");
        double T2 = double.Parse(Console.ReadLine());
        double c = (T1 * T2);
        Console.WriteLine("Área del Rectangulo: " + c);

        
    }
}
