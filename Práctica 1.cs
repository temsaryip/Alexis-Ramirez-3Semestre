using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        
        int entero = 0;
        char variable ;
        string cadenaTexto;
        float flotante = 0;
        double doble = 0;
        bool booleano;
        // entrada de dto
        Console.WriteLine("Ingresa un valor entero: ");
        entero = int.Parse(Console.ReadLine());
        Console.WriteLine(entero);
        Console.WriteLine("Ingresa una letra: ");
        variable = char.Parse(Console.ReadLine());
        Console.WriteLine(variable);
        Console.WriteLine("Ingresa una frase: ");
        cadenaTexto = (Console.ReadLine());
        Console.WriteLine(cadenaTexto);
        Console.WriteLine("Ingresa un valor decimal: ");
        flotante = float.Parse(Console.ReadLine());
        Console.WriteLine(flotante);
        Console.WriteLine("Ingresa un valor booleano: ");
        booleano = bool.Parse(Console.ReadLine());
        Console.WriteLine(booleano);
    }
}
